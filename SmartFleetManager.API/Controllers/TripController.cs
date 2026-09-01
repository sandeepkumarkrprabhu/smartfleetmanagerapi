using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;
using System.Globalization;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ITripService _tripService;
        private readonly ILogger<TripController> _logger;

        public TripController(AppDbContext context, ILogger<TripController> logger, ITripService tripService)
        {
            _context = context;
            _logger = logger;
            _tripService = tripService;
        }

        // GET: api/<TripTransactions>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripTransactionView>>> GetTrips(string yearCode)
        {
            _logger.LogInformation("Fetching all trip/Dispatches from database.");
            try
            {
                var trips = from t in _context.TripTransaction
                            join fC in _context.Customers on t.StockistID equals fC.Id
                            join tC in _context.Customers on t.ToCustomerId equals tC.Id
                            join v in _context.Vehilces on t.VehicleId equals v.Id
                            join ve in _context.Vendors on t.VendorId equals ve.Id
                            join e in _context.Employees on t.EmployeeId equals e.Id
                            join o in _context.Locations on t.OriginId equals o.Id
                            join d in _context.Locations on t.DestinationId equals d.Id
                            where (t.Status != "Cancelled") && t.YearCode == yearCode
                            select new TripTransactionView
                            {
                                Id = t.Id,
                                Code = t.Code,
                                FromCustomer = fC.Name,
                                ToCustomer = tC.Name,
                                Vehicle = v.Name,
                                Vendor = ve.Name,
                                VendorRentCharges = t.VendorRentCharges ?? 0,
                                Employee = e.Name,
                                LrNo = "",
                                LRDate = t.LRDate,
                                InvoiceNo = "",
                                Route = t.Route ?? "",
                                Origin = o.Name,
                                Destination = d.Name,
                                StartDate = t.StartDate,
                                ExpectedDeliveryDate = t.ExpectedDeliveryDate,
                                Status = t.Status ?? "Planned",
                                ProductCount = t.ProductCount,
                                Notes = t.Notes ?? "",
                                ReferenceNo = t.ReferenceNo ?? "",
                                Mtn = t.MtnNo ?? 0,
                                Kms = t.Kms ?? 0,
                                FreightCost = t.FrieghtCharges ?? 0,
                                TotalCost = t.finalAmount??0,
                                IsReceiptReceived = t.IsReceiptReceived,
                                TransactionReferenceId = t.TransactionReferenceId,
                                TransactionStatus = t.TransactionStatus ??"",
                                ConsigneeDetails = (from tc in _context.TripConsigneeDetails
                                                    join c in _context.Customers on tc.ToConsigneeId equals c.Id
                                                    join d in _context.Locations on tc.DestinationId equals d.Id
                                                    where tc.TripTransactionId == t.Id
                                                    select new TripConsigneeDetailsView
                                                    {
                                                        Id = tc.Id,
                                                        ToConsigneeId = tc.ToConsigneeId,
                                                        DestinationId = tc.DestinationId,
                                                        ConsigneeName = c.Name,
                                                        DestinationLocationName = d.Name,
                                                        LrNo = tc.LRNo ?? "",
                                                        InvoiceNo = tc.InvoiceNo ?? "",
                                                        GoodsValue = tc.GoodsValue ?? 0,
                                                        FreightCharges = tc.FreightCharges
                                                    }).ToList(),

                            };

                var result = await trips.ToListAsync();

                foreach (var trip in result)
                {
                    trip.LrNo = string.Join(", ",
                        trip.ConsigneeDetails
                            .Select(x => x.LrNo)
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Distinct()
                    );

                    trip.InvoiceNo = string.Join(", ",
                        trip.ConsigneeDetails
                            .Select(x => x.InvoiceNo)
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Distinct()
                    );
                }
                var processedTrips = await trips.OrderByDescending(o => o.LRDate).ToListAsync();
                _logger.LogInformation("Fetched {Count} trips/dispatches.", result.Count);
                return Ok(processedTrips);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching trip/dispatch.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<TripTransactions>
        [HttpGet("GetPendingInvoiceTrips")]
        public async Task<ActionResult<IEnumerable<TripTransaction>>> GetPendingInvoiceTrips()
        {
            _logger.LogInformation("Fetching all pending trip/Dispatches to invoice from database.");
            try
            {
                var trips = await (from t in _context.TripTransaction
                                   join fC in _context.Customers on t.FromCustomerId equals fC.Id
                                   join tC in _context.Customers on t.ToCustomerId equals tC.Id
                                   join v in _context.Vehilces on t.VehicleId equals v.Id
                                   join ve in _context.Vendors on t.VendorId equals ve.Id
                                   join e in _context.Employees on t.EmployeeId equals e.Id
                                   join o in _context.Locations on t.OriginId equals o.Id
                                   join d in _context.Locations on t.DestinationId equals d.Id
                                   where t.Status == "Delivered"
                                   select new TripTransactionView
                                   {
                                       Id = t.Id,
                                       Code = t.Code,
                                       FromCustomer = (t.IsSalesReturnTrip ? tC.Name : fC.Name),
                                       ToCustomer = (t.IsSalesReturnTrip ? fC.Name : tC.Name),
                                       Vehicle = v.Name,
                                       Vendor = ve.Name,
                                       VendorRentCharges = t.VendorRentCharges ?? 0,
                                       Employee = e.Name,
                                       Route = t.Route ?? "",
                                       Origin = o.Name,
                                       Destination = d.Name,
                                       StartDate = t.StartDate,
                                       ExpectedDeliveryDate = t.ExpectedDeliveryDate,
                                       Status = t.Status ?? "Planned",
                                       ProductCount = 1,
                                       Notes = t.Notes ?? "",
                                       ReferenceNo = t.ReferenceNo ?? "",
                                       Mtn = t.MtnNo ?? 0,
                                       Kms = t.Kms ?? 0,
                                       FreightCost = t.FrieghtCharges ?? 0,
                                       IsReceiptReceived = t.IsReceiptReceived,
                                   }).ToListAsync();
                _logger.LogInformation("Fetched {Count} trips/dispatches.", trips.Count);
                return Ok(trips);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching trip/dispatch.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }


        // GET: api/<TripTransactions>
        [HttpGet("GetLatestTrips")]
        public async Task<ActionResult<IEnumerable<List<TripTransaction>>>> GetRecentTrips()
        {
            _logger.LogInformation("Fetching recent trips from database.");
            try
            {
                var latestTrips = await (from t in _context.TripTransaction
                                         join fC in _context.Customers on t.FromCustomerId equals fC.Id
                                         join tC in _context.Customers on t.ToCustomerId equals tC.Id
                                         join v in _context.Vehilces on t.VehicleId equals v.Id
                                         join ve in _context.Vendors on t.VendorId equals ve.Id
                                         join e in _context.Employees on t.EmployeeId equals e.Id
                                         join o in _context.Locations on t.OriginId equals o.Id
                                         join d in _context.Locations on t.DestinationId equals d.Id
                                         where (t.Status != "Cancelled")
                                         select new TripTransactionView
                                         {
                                             Id = t.Id,
                                             Code = t.Code,
                                             FromCustomer = fC.Name,
                                             ToCustomer = tC.Name,
                                             Vehicle = v.Name,
                                             Vendor = ve.Name,
                                             VendorRentCharges = t.VendorRentCharges ?? 0,
                                             Employee = e.Name,
                                             LrNo = t.ReferenceNo ?? "",
                                             LRDate = t.LRDate,
                                             InvoiceNo = t.InvoiceNo ?? "",
                                             Route = t.Route ?? "",
                                             Origin = o.Name,
                                             Destination = d.Name,
                                             StartDate = t.StartDate,
                                             ExpectedDeliveryDate = t.ExpectedDeliveryDate,
                                             Status = t.Status ?? "Planned",
                                             ProductCount = t.ProductCount,
                                             Notes = t.Notes ?? "",
                                             ReferenceNo = t.ReferenceNo ?? "",
                                             IsReceiptReceived = t.IsReceiptReceived,
                                             Mtn = t.MtnNo ?? 0,
                                             Kms = t.Kms ?? 0,
                                         }).OrderByDescending(p => p.LRDate).Take(10).ToListAsync();
                _logger.LogInformation("Fetched latest/recent Trip/Dispatch.");
                return Ok(new { latestTrips });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current trip Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpGet("GetTripReport")]
        public IActionResult GetTripReport([FromQuery] TripReportFilterDto filter)
        {
            var query = from t in _context.TripTransaction
                        join c in _context.Customers on t.FromCustomerId equals c.Id
                        join s in _context.Customers on t.StockistID equals s.Id
                        join d in _context.Employees on t.EmployeeId equals d.Id
                        join v in _context.Vehilces on t.VehicleId equals v.Id
                        join ve in _context.Vendors on t.VendorId equals ve.Id
                        join fl in _context.Locations on t.OriginId equals fl.Id
                        join tl in _context.Locations on t.DestinationId equals tl.Id
                        where t.Status != "Cancelled"
                        select new TripReportResultDto
                        {
                            LRNo = string.Join("/ ",
                                _context.TripConsigneeDetails
                                    .Where(x => x.TripTransactionId == t.Id && x.LRNo != null)
                                    .Select(x => x.LRNo)),
                            LRDate = t.LRDate,

                            // GET ALL INVOICE NOS
                            RmtInvoiceNo = string.Join(", ",
                                _context.TripConsigneeDetails
                                    .Where(x => x.TripTransactionId == t.Id && x.InvoiceNo != null)
                                    .Select(x => x.InvoiceNo)
                            ),
                            ConsigneeName = string.Join(Environment.NewLine,
                                            _context.TripConsigneeDetails
                                                .Where(x => x.TripTransactionId == t.Id)
                                                .Select(x =>
                                                    (x.ToConsignee != null ? x.ToConsignee.Name : "") +
                                                    " - " +
                                                    (x.Destination != null ? x.Destination.Name : "")
                                                )
                                        ),
                            status = t.Status ?? "",

                            VehicleNo = v.Name,
                            VehicleType = v.VehicleType,

                            Vendor = ve.Name,
                            VendorRentCharges = t.VendorRentCharges ?? 0,

                            FromLocation = fl.Name,
                            ToLocation = tl.Name,

                            StockistName = s.Name,
                            CustomerName = c.Name,
                            DriverName = d.Name,

                            MTN = t.MtnNo,
                            KMS = t.Kms,

                            Commission = t.CommissionAmt,
                            GoodsValue = t.GoodsValue ?? 0,
                            LRCharges = t.LRCharges ?? 0,
                            HaltingCharges = t.HaltingCharges ?? 0,
                            HandlingCharges = t.HandlingCharges ?? 0,

                            FreightCharges = t.FrieghtCharges ?? 0,
                            DriverCharges = t.DriverBata,
                            FuelCharges = t.FuelCharges,
                            TollCharges = t.TollCharges,

                            TotalCost = t.TotalCost,
                            Notes = t.Notes ?? ""
                        };


            // Optional filters
            if (!string.IsNullOrEmpty(filter.Stockist))
                query = query.Where(x => x.StockistName.ToLower().StartsWith(filter.Stockist.ToLower()));

            if (!string.IsNullOrEmpty(filter.Customer))
                query = query.Where(x => x.CustomerName.ToLower().StartsWith(filter.Customer.ToLower()));

            if (!string.IsNullOrEmpty(filter.Status))
                query = query.Where(x => x.status.ToLower().Contains(filter.Status.ToLower()));

            if (!string.IsNullOrEmpty(filter.Driver))
                query = query.Where(x => x.DriverName.ToLower().StartsWith(filter.Driver.ToLower()));

            if (!string.IsNullOrEmpty(filter.Vehicle))
                query = query.Where(x => x.VehicleNo.Contains(filter.Vehicle));

            if (!string.IsNullOrEmpty(filter.Vendor))
                query = query.Where(x => x.Vendor.ToLower().StartsWith(filter.Vendor.ToLower()));

            if (!string.IsNullOrEmpty(filter.DocketNo))
                query = query.Where(x => x.RmtInvoiceNo.Contains(filter.DocketNo));

            if (!string.IsNullOrEmpty(filter.LRNo))
                query = query.Where(x => x.LRNo.Contains(filter.LRNo));

            if (filter.FromDate != null && filter.FromDate.ToString() != "")
                query = query.Where(x => x.LRDate >= filter.FromDate);

            if (filter.ToDate != null && filter.ToDate.ToString() != "")
                query = query.Where(x => x.LRDate <= filter.ToDate);
            var result = query.OrderBy(o => o.LRDate).ToList();
            return Ok(result);
        }


        // GET: api/<TripTransactions>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last trip code from database.");
            try
            {
                var currentCode = await _context.TripTransaction.OrderByDescending(p => p.Id).Select(s => s.Code).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for Trip/Dispatch.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current trip Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var deliveredTrips = await _context.TripTransaction
                    .Where(p => (p.LRDate >= filter.StartDate &&
                                p.LRDate <= filter.EndDate) &&
                                (p.Status == "Delivered" || p.Status == "Billed") &&
                                (p.TransactionStatus == "Draft" || string.IsNullOrEmpty(p.TransactionStatus)) &&
                                (
                                    (p.VendorRentCharges ?? 0) > 0 || p.DriverBata > 0)
                                ).ToListAsync();

            if (!deliveredTrips.Any())
            {
                return NotFound("No trips found for the selected date range.");
            }

            foreach (var trip in deliveredTrips)
            {
                if (trip != null)
                {
                    await _tripService.PostTripToAccountsAsync(trip.Id);
                }
            }

            return Ok(new
            {
                Message = "Lorry Receipt posting completed",
                Count = deliveredTrips.Count
            });
        }

        // GET: api/TripTransactions/PendingOrders/1
        [HttpGet("PendingOrders/{id}")]
        public async Task<ActionResult<IEnumerable<TripTransactionView>>> GetCustomerPendingOrders(int id)
        {
            _logger.LogInformation($"Fetching pending trips/orders for customer {id}.");
            try
            {
                var pendingTrips = await (from t in _context.TripTransaction
                                          join sC in _context.Customers on t.StockistID equals sC.Id
                                          join tC in _context.Customers on t.ToCustomerId equals tC.Id
                                          join v in _context.Vehilces on t.VehicleId equals v.Id
                                          join ve in _context.Vendors on t.VendorId equals ve.Id
                                          join e in _context.Employees on t.EmployeeId equals e.Id
                                          join o in _context.Locations on t.OriginId equals o.Id
                                          join d in _context.Locations on t.DestinationId equals d.Id
                                          where ((t.Status == "Delivered") && ((t.BillNo ?? 0) == 0) && (t.StockistID == id))
                                          select new TripTransactionView
                                          {
                                              Id = t.Id,
                                              LrNo = t.ReferenceNo ?? "",
                                              InvoiceNo = t.InvoiceNo ?? "",
                                              LRDate = t.LRDate,
                                              Code = t.Code,
                                              ToCustomer = tC.Name,
                                              VehicleId = t.VehicleId,
                                              VendorId = t.VendorId ?? 0,
                                              VendorRentCharges = t.VendorRentCharges ?? 0,
                                              Vehicle = v.Name,
                                              Vendor = ve.Name,
                                              EmployeeId = t.EmployeeId,
                                              Employee = e.Name,
                                              Route = t.Route ?? "",
                                              OriginId = t.OriginId,
                                              Origin = o.Name,
                                              DestinationId = t.DestinationId,
                                              Destination = d.Name,
                                              StartDate = t.StartDate,
                                              ExpectedDeliveryDate = t.ExpectedDeliveryDate,
                                              Status = t.Status ?? "Scheduled",
                                              ProductCount = t.ProductCount,
                                              Notes = t.Notes ?? "",
                                              ReferenceNo = t.ReferenceNo ?? "",
                                              Mtn = t.MtnNo ?? 0,
                                              Kms = t.Kms ?? 0,
                                              FreightCost = t.FrieghtCharges ?? 0,
                                              AdditionalCost = t.AdditionalCost,
                                              CommissionAmount = t.CommissionAmt,
                                              LoadingCost = t.LoadingCost,
                                              TotalCost = t.TotalCost,
                                              TaxPer = t.TaxPercentage ?? 0,
                                              CGST = t.CGSTAmount ?? 0,
                                              SGST = t.SGSTAmount ?? 0,
                                              IGST = t.IGSTAmount ?? 0,
                                              billNo = t.BillNo ?? 0,
                                              IsReceiptReceived = t.IsReceiptReceived
                                          }).ToListAsync();

                _logger.LogInformation($"Fetched {pendingTrips.Count} pending trips/orders for customer {id}.");
                return Ok(pendingTrips);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching pending trips/orders.");
                return StatusCode(500, $"An error occurred while retrieving data. Error: {ex.Message}");
            }
        }

        // GET api/<TripTransactions>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripTransaction>> GetTrip(int id)
        {
            _logger.LogInformation("Fetching trip with ID {Id}.", id);

            try
            {
                var trip = await _context.TripTransaction
                            .Include(c => c.ConsigneeDetails)
                            .Where(t => t.Status != "Cancelled")
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (trip == null)
                {
                    _logger.LogWarning("Trip with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(trip);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching trip with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the trip/dispatch.");
            }
        }

        [HttpGet("trips")]
        public IActionResult GetTrips([FromQuery] TripReportFilterDto filter)
        {
            var query = _context.TripTransaction.Where(f => f.Status != "Cancelled").AsQueryable();

            if (!string.IsNullOrEmpty(filter.Customer))
                query = query.Where(x => x.FromCustomer.Name.Contains(filter.Customer));

            if (!string.IsNullOrEmpty(filter.Customer))
                query = query.Where(x => x.ToCustomer.Name.Contains(filter.Customer));

            if (!string.IsNullOrEmpty(filter.Status))
                query = query.Where(x => x.Status == filter.Status);

            if (!string.IsNullOrEmpty(filter.DocketNo))
                query = query.Where(x => x.InvoiceNo != null && x.InvoiceNo.Contains(filter.InvoiceNo));

            if (!string.IsNullOrEmpty(filter.DocketNo))
                query = query.Where(x => x.ReferenceNo != null && x.ReferenceNo.Contains(filter.DocketNo));

            if (filter.FromDate != null)
                query = query.Where(x => x.StartDate >= filter.FromDate);

            if (filter.FromDate != null)
                query = query.Where(x => x.ExpectedDeliveryDate <= filter.ToDate);

            return Ok(query.ToList());
        }


        // POST api/<TripTransactions>
        [HttpPost]
        public async Task<ActionResult<TripTransaction>> PostTrip(TripTransaction trip)
        {
            _logger.LogInformation("Creating a new Trip/Dispatch.");
            try
            {

                if (trip == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = trip.ReferenceNo?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("trip LR No is required.");
                }

                // Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.TripConsigneeDetails
                    .AnyAsync(c => c.LRNo.Contains(name));

                if (isAlreadyExists)
                {
                    return Conflict("trip with LR No already exists.");
                }

                _context.TripTransaction.Add(trip);
                await _context.SaveChangesAsync();

                var newId = trip.Id;

                //post the transation to accounts
                await _tripService.PostTripToAccountsAsync(trip.Id);

                _logger.LogInformation("Trip/Dispatch created with ID {Id}.", trip.Id);
                return CreatedAtAction(nameof(GetTrip), new { id = trip.Id }, trip);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new trip.");
                return StatusCode(500, "An error occurred while creating the trip.");
            }
        }

        // PUT api/<TripTransactions>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrip(int id, TripTransaction trip)
        {
            _logger.LogInformation("Updating trip with ID {Id}.", id);

            if (id != trip.Id)
                return BadRequest("Trip ID mismatch");

            var existingTrip = await _context.TripTransaction
                .Include(t => t.ConsigneeDetails)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (existingTrip == null)
                return NotFound();


            // =========================================
            // 1️ Delete AccountTransaction
            // =========================================
            if (trip.TransactionStatus == "Posted")
            {
                // Find the transaction by TransactionReferenceId
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == trip.TransactionReferenceId);

                if (accountTransaction != null)
                {
                    // Remove the account transaction
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }

            // =========================================
            // 1️⃣ UPDATE HEADER
            // =========================================
            trip.TransactionReferenceId = 0;
            trip.TransactionStatus = "Planned";
            _context.Entry(existingTrip).CurrentValues.SetValues(trip);

            
            // =========================================
            // 3️⃣ UPDATE CONSIGNEE DETAILS
            // =========================================
            if (trip.ConsigneeDetails != null)
            {
                // Remove deleted consignees
                foreach (var existingConsignee in existingTrip.ConsigneeDetails.ToList())
                {
                    if (!trip.ConsigneeDetails.Any(c => c.Id == existingConsignee.Id))
                    {
                        _context.Remove(existingConsignee);
                    }
                }

                foreach (var incomingConsignee in trip.ConsigneeDetails)
                {
                    var existingConsignee = existingTrip.ConsigneeDetails
                        .FirstOrDefault(c => c.Id == incomingConsignee.Id);

                    if (existingConsignee != null)
                    {
                        // Update existing
                        existingConsignee.LRNo = incomingConsignee.LRNo;
                        existingConsignee.InvoiceNo = incomingConsignee.InvoiceNo; 
                        existingConsignee.ToConsigneeId = incomingConsignee.ToConsigneeId;
                        existingConsignee.DestinationId = incomingConsignee.DestinationId;
                        existingConsignee.ProductId = incomingConsignee.ProductId;
                        existingConsignee.UnitId = incomingConsignee.UnitId;
                        existingConsignee.Qty = incomingConsignee.Qty;
                        existingConsignee.GoodsValue = incomingConsignee.GoodsValue;
                        existingConsignee.FreightCharges = incomingConsignee.FreightCharges;
                    }
                    else
                    {
                        // Add new
                        existingTrip.ConsigneeDetails.Add(new TripConsigneeDetails
                        {
                            LRNo = incomingConsignee.LRNo,
                            InvoiceNo = incomingConsignee.InvoiceNo,
                            ToConsigneeId = incomingConsignee.ToConsigneeId,
                            DestinationId = incomingConsignee.DestinationId,
                            ProductId = incomingConsignee.ProductId,
                            UnitId = incomingConsignee.UnitId,
                            Qty = incomingConsignee.Qty,
                            GoodsValue = incomingConsignee.GoodsValue,
                            FreightCharges = incomingConsignee.FreightCharges,
                        });
                    }
                }
            }

            try
            {
                await _context.SaveChangesAsync();

                //post the transation to accounts
                await _tripService.PostTripToAccountsAsync(trip.Id);


            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, "Error occurred while updating trip with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the trip.");
            }

            return NoContent();
        }


        // DELETE api/<TripTransactions>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrip(int id)
        {
            _logger.LogInformation("Deleting trip/dispatch with ID {Id}.", id);
            try
            {
                var selectedTrip = await _context.TripTransaction.FindAsync(id);
                var billedTrip = await _context.BillItemDetails.Where(p => p.TripId == id).FirstOrDefaultAsync();
                if (billedTrip != null)
                {
                    _logger.LogWarning("Attempted to delete billed trip with ID {Id}.", id);
                    return NotFound();
                }
                if (selectedTrip == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent trip with ID {Id}.", id);
                    return NotFound();
                }

                if (selectedTrip.TransactionStatus =="Posted")
                {
                    // Find the transaction by TransactionReferenceId
                    var accountTransaction = await _context.AccountTransactions
                        .FirstOrDefaultAsync(t => t.Id == selectedTrip.Id);

                    if (accountTransaction != null)
                    {
                        // Remove the account transaction
                        _context.AccountTransactions.Remove(accountTransaction);
                        _context.SaveChanges();
                    }
                }

                selectedTrip.Status = "Cancelled";

                selectedTrip.Notes = $"LR:{selectedTrip.ReferenceNo}, Invoice No:{selectedTrip.InvoiceNo}";

                selectedTrip.ReferenceNo = "0";
                selectedTrip.InvoiceNo = "";

                var consigneeDetails = await _context.TripConsigneeDetails
                    .Where(x => x.TripTransactionId == id)
                    .ToListAsync();

                foreach (var detail in consigneeDetails)
                {
                    detail.InvoiceNo = "";
                    detail.LRNo = "0";
                }

                await _context.SaveChangesAsync();

                _logger.LogInformation("Trip/Dispatch with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting trip/dispatch with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the trip/dispatch.");
            }
        }

        private bool TripExists(int id)
        {
            return _context.TripTransaction.Any(e => e.Id == id);
        }
    }
}
