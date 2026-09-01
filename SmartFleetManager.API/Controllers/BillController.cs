using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;
using SmartFleetManager.API.Services;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IInvoiceService _invoiceService;
        private readonly ILogger<BillController> _logger;

        public BillController(AppDbContext context, ILogger<BillController> logger, IInvoiceService invoiceService)
        {
            _context = context;
            _logger = logger;
            _invoiceService = invoiceService;
        }

        // GET: api/<BillController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetCustomerBills(string yearCode)
        {
            _logger.LogInformation("Fetching all customer invoices from database.");
            try
            {
                var raw = await (
                                from b in _context.BillTransaction
                                join bd in _context.BillItemDetails on b.Id equals bd.BTId
                                join t in _context.TripTransaction on bd.TripId equals t.Id
                                join c in _context.Customers on b.CustomerId equals c.Id
                                where b.IsDeleted != true && b.status != ""
                                && b.YearCode == yearCode
                                select new
                                {
                                    b.Id,
                                    b.RMTInvoiceNo,
                                    b.Code,
                                    b.BillDate,
                                    b.CustomerId,
                                    c.Name,
                                    c.Address,
                                    c.Phone,
                                    c.Email,
                                    c.GSTNo,
                                    c.PanNo,
                                    b.status,
                                    b.GrandAmount,
                                    t.ReferenceNo
                                }
                            ).ToListAsync();

                var customerInvoices = raw
                    .GroupBy(x => new
                    {
                        x.Id,
                        x.RMTInvoiceNo,
                        x.Code,
                        x.BillDate,
                        x.CustomerId,
                        x.Name,
                        x.Address,
                        x.Phone,
                        x.Email,
                        x.GSTNo,
                        x.PanNo,
                        x.status,
                        x.GrandAmount
                    })
                    .Select(g => new CustomerInvoice
                    {
                        Id = g.Key.Id,
                        RMTInvoiceNo = g.Key.RMTInvoiceNo,
                        InvoiceNo = g.Key.Code,
                        InvoiceDate = g.Key.BillDate,
                        CustomerId = g.Key.CustomerId.ToString(),
                        CustomerName = g.Key.Name,
                        CustomerAddress = g.Key.Address,
                        CustomerPhoneNo = g.Key.Phone,
                        CustomerEmail = g.Key.Email,
                        CustomerGST = g.Key.GSTNo,
                        CustomerPanNo = g.Key.PanNo,
                        status = g.Key.status,
                        TotalAmount = g.Key.GrandAmount,
                        LrNo = string.Join(",", g
                            .Select(x => x.ReferenceNo)
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Distinct())
                    })
                    .OrderByDescending(o => o.InvoiceDate).ThenByDescending(o => o.RMTInvoiceNo)
                    .ToList();

                _logger.LogInformation("Fetched {Count} invoices.", customerInvoices.Count);
                return Ok(customerInvoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer invoices.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        [HttpGet("GetCustomerInvoiceSummaryPrint/{id}")]
        public async Task<ActionResult<IEnumerable<MonthlyInvoiceSummaryPrint>>> GetCustomerInvoiceSummaryPrint(int id)
        {
            _logger.LogInformation("Fetching customer Monthly Summary invoices from database for invoice - {id}.", id);

            try
            {
                var companyDetail = await _context.Companies
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                var invoices = await (from b in _context.BillTransaction
                                      join bd in _context.BillItemDetails on b.Id equals bd.BTId
                                      join t in _context.TripTransaction on bd.TripId equals t.Id
                                      join v in _context.Vehilces on t.VehicleId equals v.Id
                                      join bc in _context.Customers on b.CustomerId equals bc.Id
                                      join l in _context.Locations on t.OriginId equals l.Id
                                      where b.Id == id
                                      select new MonthlyInvoiceSummaryPrint
                                      {
                                          CompanyName = companyDetail.Name ?? "",
                                          CompanyAddress = companyDetail.Address,
                                          CompanyEmail = companyDetail.EmailId,
                                          CompanyPhoneNo = companyDetail.ContactPhone,
                                          CompanyGST = companyDetail.GSTNo,
                                          CompanyPAN = companyDetail.PANNo,
                                          CompanySACNo = companyDetail.SACNo,
                                          BillNo = b.RMTInvoiceNo.ToString(),
                                          BillDate = b.BillDate,
                                          BillingPeriod = ($"{b.BIllFromDate:dd/MM/yyyy} - {b.BillToDate:dd/MM/yyyy}"),
                                          BillAmount = b.TotalAmount,
                                          CustomerName = bc.Name ?? "",
                                          CustomerAddress = bc.Address,
                                          CustomerPhoneNo = bc.Phone,
                                          CustomerEmail = bc.Email,
                                          CustomerGST = bc.GSTNo,
                                          CustomerPAN = bc.PanNo,
                                          InvoiceTemplateName = bc.InvoiceTemplateName ?? "",
                                          InvoiceNo = (from tc in _context.TripConsigneeDetails
                                                      where tc.TripTransactionId == t.Id
                                                      select tc.InvoiceNo).FirstOrDefault()??"",
                                          InvoiceDate = t.LRDate,
                                          LoadingPoint = l.Name,
                                          OffLoadingPoint = string.Join("/ ",
                                                    from tc in _context.TripConsigneeDetails
                                                    join ol in _context.Locations
                                                        on tc.DestinationId equals ol.Id
                                                    where tc.TripTransactionId == t.Id
                                                    select ol.Name
                                                ),
                                          allInvoiceFreights = string.Join(", ",
                                                _context.TripConsigneeDetails
                                                    .Where(tc => tc.TripTransactionId == t.Id)
                                                    .Select(tc => tc.FreightCharges)),
                                          DeliveryCharges = t.AdditionalCost,
                                          LoadingUnloadingCharges = t.LoadingCost,
                                          totalAmount = t.TotalCost,
                                          ConsigneeName = string.Join("/ ",
                                                        from tc in _context.TripConsigneeDetails
                                                        join c in _context.Customers
                                                            on tc.ToConsigneeId equals c.Id
                                                        where tc.TripTransactionId == t.Id
                                                        select c.Name
                                                    ),
                                          LrNo = string.Join("/ ",
                                                _context.TripConsigneeDetails
                                                    .Where(tc => tc.TripTransactionId == t.Id)
                                                    .Select(tc => tc.LRNo)),
                                          LrDate = t.LRDate,
                                          VehicleNo = v.Name,
                                          VehicleType = v.VehicleType,
                                          KMS = t.Kms ?? 0,
                                          mtnNo = (t.MtnNo??0),
                                          goodsValue = t.GoodsValue??0,
                                          haltingCharges = t.HaltingCharges ?? 0,
                                          FreightCharges = t.FrieghtCharges ?? 0,
                                          Remarks = t.Notes ?? "",
                                          IsSalesReturn = t.IsSalesReturnTrip
                                      }).ToListAsync();
                
                invoices = invoices.Select((x, index) =>
                            {
                                x.SlNo = index + 1;
                                return x;
                            }).ToList();

                return invoices;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer invoices.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        // GET: api/<BillController>/GetOutstandingInvoices
        [HttpGet("GetOutstandingInvoices/{id}")]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetOutstandingInvoices(int id)
        {
            _logger.LogInformation("Fetching customer invoices Outstanding to Invoice");
            try
            {
                var customerInvoices = await (
                            from bt in _context.BillTransaction
                            join c in _context.Customers
                            on bt.CustomerId equals c.Id
                            where c.AccountId == id && bt.status == "Billed" && bt.IsDeleted != true
                            orderby bt.RMTInvoiceNo
                            select new
                            {
                                bt.Id,
                                bt.RMTInvoiceNo,
                                bt.TotalAmount,
                                bt.CustomerId,
                                c.AccountId,
                                c.Name,
                                bt.BillDate
                            }
                        ).ToListAsync();

                if (customerInvoices == null)
                {
                    _logger.LogWarning("customer Invoices outstanding not found.");
                    return NotFound();
                }

                return Ok(customerInvoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer Invocie outstanding.");
                return StatusCode(500, $"An error occurred while retrieving the customer outstanding invoice.{ex.StackTrace}");
            }
        }

        // GET: api/<BillController>/GetVendorOutstandingInvoices
        [HttpGet("GetVendorOutstandingInvoice/{id}")]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetVendorOutstandingInvoice(int id)
        {
            _logger.LogInformation("Fetching vendor rent Outstanding to Invoice");
            try
            {
                var vendorInvoices = await (
                            from bt in _context.BillTransaction
                            join bi in _context.BillItemDetails on bt.Id equals bi.BTId
                            join t in _context.TripTransaction on bi.TripId equals t.Id
                            join v in _context.Vendors on t.VendorId equals v.Id
                            where v.AccountId == id && bt.status == "Billed" && bt.IsDeleted != true && t.VendorRentCharges > 0
                            orderby bt.RMTInvoiceNo
                            select new
                            {
                                bt.Id,
                                bt.RMTInvoiceNo,
                                TotalAmount = t.VendorRentCharges,
                                bt.CustomerId,
                                v.AccountId,
                                v.Name,
                                bt.BillDate
                            }
                        ).ToListAsync();

                if (vendorInvoices == null)
                {
                    _logger.LogWarning("customer Invoices outstanding not found.");
                    return NotFound();
                }

                return Ok(vendorInvoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer Invocie outstanding.");
                return StatusCode(500, $"An error occurred while retrieving the customer outstanding invoice.{ex.StackTrace}");
            }
        }

        [HttpGet("GetCustomerInvoice/{id}")]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetCustomerInvoice(int id)
        {
            _logger.LogInformation("Fetching customer invoices from database.");

            try
            {

                var companyDetail = await _context.Companies
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                var invoiceHeader = await (
                    from b in _context.BillTransaction
                    join c in _context.Customers on b.CustomerId equals c.Id
                    where b.Id == id
                    select new
                    {
                        b.Id,
                        b.Code,
                        b.RMTInvoiceNo,
                        b.BillDate,
                        b.TotalAmount,
                        b.status,
                        b.TaxPer,
                        b.TotalTaxAmount,
                        b.GrandAmount,

                        CustomerId = c.Id,
                        CustomerName = c.Name,
                        CustomerAddress = c.Address,
                        CustomerPhoneNo = c.Phone,
                        CustomerEmail = c.Email,
                        CustomerGST = c.GSTNo,
                        CustomerPan = c.PanNo,
                        CustomerTemplate = c.InvoiceTemplateName,
                    }
                ).FirstOrDefaultAsync();

                if (invoiceHeader == null)
                    return NotFound("Invoice not found.");

                var invoiceDetails = await (from bd in _context.BillItemDetails
                                            join t in _context.TripTransaction on bd.TripId equals t.Id
                                            join v in _context.Vehilces on t.VehicleId equals v.Id
                                            join o in _context.Locations on bd.OriginId equals o.Id
                                            join d in _context.Locations on bd.DestinationId equals d.Id
                                            where bd.BTId == id
                                            select new CustomerInvoiceDetail
                                            {
                                                LRDate = t.LRDate,
                                                FromCustomerName = t.FromCustomer.Name ?? "",
                                                ToCustomerName = t.ToCustomer.Name ?? "",
                                                FromStockistName = t.FromStockist.Name ?? "",
                                                Origin = o.Name,
                                                Destination = d.Name,
                                                LRNo = t.ReferenceNo ?? "",
                                                InvoiceNo = t.InvoiceNo ?? "",
                                                KMS = t.Kms ?? 0,
                                                GoodsValue = t.GoodsValue ?? 0,
                                                Freight = t.FrieghtCharges ?? 0,
                                                haltingCharges = t.HaltingCharges ?? 0,
                                                handlingCharges = t.HandlingCharges ?? 0,
                                                LoadingCharges = t.LoadingCost,
                                                LrCharges = t.LRCharges ?? 0,
                                                EstiamteCost = t.TotalCost,
                                                TripId = bd.TripId,
                                                VehicleId = bd.VehicleId,
                                                VehicleType = v.VehicleType,
                                                DriverId = bd.EmployeeId,
                                                Route = bd.Route,
                                                TripCode = t.Code,
                                                VehicleNo = v.Name,
                                                remarks = t.Notes ?? "",
                                                IsSalesReturn = t.IsSalesReturnTrip,
                                                Description = string.Join(", ",
                                                        _context.TripConsigneeDetails
                                                            .Where(tc => tc.TripTransactionId == t.Id)
                                                            .Join(
                                                                _context.Products,
                                                                tc => tc.ProductId,
                                                                p => p.Id,
                                                                (tc, p) => p.Name
                                                            ).ToList())
                                            }).ToListAsync();

                if (invoiceDetails == null)
                    return NotFound("Invoice Details not found.");

                var invoice = new CustomerInvoice
                {
                    CompanyName = companyDetail?.Name,
                    CompanyAddress = companyDetail?.Address,
                    CompanyPhoneNo = companyDetail?.ContactPhone,
                    CompanyEmail = companyDetail?.EmailId,
                    CompanyGst = companyDetail?.GSTNo,
                    CompanyPan = companyDetail?.PANNo,
                    CompanySac = companyDetail?.SACNo,

                    InvoiceNo = invoiceHeader.Code,
                    RMTInvoiceNo = invoiceHeader.RMTInvoiceNo,
                    InvoiceDate = invoiceHeader.BillDate,
                    CustomerId = invoiceHeader.CustomerId.ToString(),
                    CustomerName = invoiceHeader.CustomerName,
                    CustomerAddress = invoiceHeader.CustomerAddress,
                    CustomerPhoneNo = invoiceHeader.CustomerPhoneNo,
                    CustomerEmail = invoiceHeader.CustomerEmail,
                    CustomerGST = invoiceHeader.CustomerGST,
                    CustomerPanNo = invoiceHeader.CustomerPan,
                    InvoiceTemplateName = invoiceHeader.CustomerTemplate,

                    TotalAmount = invoiceHeader.TotalAmount,
                    TaxPer = invoiceHeader.TaxPer,
                    TotalTax = invoiceHeader.TotalTaxAmount,
                    GrandAmount = invoiceHeader.GrandAmount,
                    status = invoiceHeader.status,
                    LrNo = string.Join(", ",invoiceDetails.Select(x => x.LRNo).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct()),
                    LRDate = invoiceDetails.First().LRDate,
                    isSalesReturn = invoiceDetails?.FirstOrDefault()?.IsSalesReturn??false,
                };

                var invoiceConsigneeDetails = await (from bd in _context.BillItemDetails
                                                     join t in _context.TripTransaction on bd.TripId equals t.Id
                                                     join c in _context.TripConsigneeDetails on bd.TripId equals c.TripTransactionId
                                                     join d in _context.Locations on c.DestinationId equals d.Id
                                                     join cu in _context.Customers on c.ToConsigneeId equals cu.Id
                                                     where bd.BTId == id
                                                     select new CustomerInvoiceConsigneeDetails
                                                     {
                                                         CustomerName = cu.Name,
                                                         LocationName = d.Name,
                                                         LRNo = c.LRNo ?? "",
                                                         invoiceNo = c.InvoiceNo ?? "",
                                                         GoodsValue = c.GoodsValue ?? 0
                                                     }).ToListAsync();

                if (invoiceDetails == null)
                    return NotFound("Invoice Details not found.");

                invoice.Details = invoiceDetails;
                invoice.ConsigneeDetails = invoiceConsigneeDetails;

                return Ok(invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching invoice {InvoiceId}", id);
                return StatusCode(500, "Error while retrieving invoice data.");
            }

        }

        [HttpGet("GetInvoiceGSTReport")]
        public IActionResult GetInvoiceGSTReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try
            {
                var result = (
                    from b in _context.BillTransaction
                    join c in _context.Customers on b.CustomerId equals c.Id
                    where (b.BillDate >= filter.FromDate && b.BillDate <= filter.ToDate) &&
                    !b.IsDeleted && !string.IsNullOrEmpty(b.status)
                    select new CustomerInvoiceGSTSummaryResult
                    {
                        BillDate = b.BillDate,
                        BillNo = b.RMTInvoiceNo,
                        CustomerID = b.CustomerId,
                        CustomerName = c.Name,
                        Place = c.Address,
                        GSTNo = c.GSTNo,
                        Amount = b.TotalAmount,
                        IGST = b.IGST,
                        SGST = b.SGST,
                        CGST = b.CGST,
                        Total = b.GrandAmount
                    })
                    .AsEnumerable() // switch to in-memory
                    .OrderBy(x => x.BillNo)
                    .Select((x, index) =>
                    {
                        x.SlNo = index + 1;
                        return x;
                    })
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching invoice report.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }

        }

        [HttpGet("GetCustomerInvoiceSummaryReport")]
        public IActionResult GetCustomerInvoiceSummaryReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try
            {
                var query = from b in _context.BillTransaction
                            join bd in _context.BillItemDetails on b.Id equals bd.BTId
                            join t in _context.TripTransaction on bd.TripId equals t.Id
                            join c in _context.Customers on b.CustomerId equals c.Id
                            where !b.IsDeleted && !string.IsNullOrEmpty(b.status)
                            select new
                            {
                                b.Id,
                                c.Name,
                                b.status,
                                b.RMTInvoiceNo,
                                t.ReferenceNo,
                                b.BillDate,
                                b.GrandAmount,
                                TripLR = t.ReferenceNo,
                                custoemrId = c.Id,
                                customerName = c.Name,
                                invoiceTemplate = c.InvoiceTemplateName ?? ""
                            };

                // ------------------------
                // Apply optional filters
                // ------------------------

                if (!string.IsNullOrWhiteSpace(filter.Customer))
                    query = query.Where(x => x.Name.Contains(filter.Customer));

                if (!string.IsNullOrWhiteSpace(filter.Status))
                    query = query.Where(x => x.status.Contains(filter.Status));

                if (!string.IsNullOrWhiteSpace(filter.InvoiceNo))
                    query = query.Where(x => x.RMTInvoiceNo.ToString().Contains(filter.InvoiceNo));

                if (!string.IsNullOrWhiteSpace(filter.LrNo))
                    query = query.Where(x => x.ReferenceNo.Contains(filter.LrNo));

                if (filter.FromDate.HasValue)
                    query = query.Where(x => x.BillDate >= filter.FromDate.Value);

                if (filter.ToDate.HasValue)
                    query = query.Where(x => x.BillDate <= filter.ToDate.Value);

                var result = query
                    .GroupBy(x => new
                    {
                        x.Id,
                        x.RMTInvoiceNo,
                        x.BillDate,
                        x.GrandAmount
                    })
                    .Select(g => new
                    {
                        g.Key.RMTInvoiceNo,
                        g.Key.BillDate,
                        g.Key.GrandAmount,
                        LRList = g.Select(x => x.TripLR)
                    })
                    .AsEnumerable() // Needed for string.Join
                    .OrderBy(x => x.RMTInvoiceNo)
                    .Select((x, index) => new CustomerInvoiceSummary
                    {
                        SlNo = index + 1,
                        BillNo = x.RMTInvoiceNo,
                        BillDate = x.BillDate,
                        GrandTotal = x.GrandAmount,
                        LRNo = string.Join(", ", x.LRList.Where(lr => !string.IsNullOrWhiteSpace(lr)).Distinct())
                    })
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching invoice report.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }

        }


        //[HttpGet("GetInvoiceReport")]
        //public IActionResult GetInvoiceReport([FromQuery] InvoiceReportFilterDto filter)
        //{
        //    try
        //    {
        //        var query = from b in _context.BillTransaction
        //                    join bd in _context.BillItemDetails on b.Id equals bd.BTId
        //                    join t in _context.TripTransaction on bd.TripId equals t.Id
        //                    join c in _context.Customers on b.CustomerId equals c.Id
        //                    join v in _context.Vehilces on t.VehicleId equals v.Id
        //                    join o in _context.Locations on bd.OriginId equals o.Id
        //                    join d in _context.Locations on bd.DestinationId equals d.Id
        //                    join tp in _context.TripProductDetails on t.Id equals tp.TripTransactionId
        //                    join p in _context.Products on tp.ProductId equals p.Id
        //                    where (b.IsDeleted != true && b.status != "")
        //                    select new CustomerInvoice
        //                    {
        //                        Id = b.Id,
        //                        InvoiceNo = b.RMTInvoiceNo.ToString(),
        //                        RMTInvoiceNo = b.RMTInvoiceNo.ToString(),
        //                        InvoiceDate = b.BillDate,
        //                        CustomerId = b.CustomerId.ToString(),
        //                        CustomerName = c.Name,
        //                        CustomerAddress = c.Address,
        //                        CustomerPhoneNo = c.Phone,
        //                        CustomerEmail = c.Email,
        //                        CustomerGST = c.GSTNo,
        //                        CustomerPanNo = c.PanNo,
        //                        InvoiceTemplateName = c.InvoiceTemplateName ?? "",
        //                        LrNo = t.ReferenceNo ?? "",
        //                        LRDate = t.LRDate,
        //                        StartDate = t.StartDate,
        //                        ExpectedDeliveryDate = t.ExpectedDeliveryDate,
        //                        ActualDeliveryDate = t.ActualDeliveryDate ?? DateTime.MinValue,

        //                        status = b.status,
        //                        Notes = t.Notes ?? "",
        //                        LoadingCost = t.LoadingCost,
        //                        CommissionAmount = t.CommissionAmt,
        //                        AdditionalAmount = t.AdditionalCost,
        //                        TotalAmount = t.TotalCost,
        //                        VehicleNo = v.Name,
        //                        FreightCharges = t.FrieghtCharges ?? 0,
        //                        TaxPer = 0,
        //                        TotalTax = 0,
        //                        GrandAmount = b.GrandAmount,
        //                    };

        //        // Optional filters
        //        if (!string.IsNullOrEmpty(filter.Customer))
        //            query = query.Where(x => x.CustomerName.ToLower().Contains(filter.Customer.ToLower()));

        //        if (!string.IsNullOrEmpty(filter.Status))
        //            query = query.Where(x => x.status.ToLower().Contains(filter.Status.ToLower()));

        //        //if (!string.IsNullOrEmpty(filter.Driver))
        //        //    query = query.Where(x => x.DriverName.ToLower().Contains(filter.Driver.ToLower()));

        //        //if (!string.IsNullOrEmpty(filter.Vehicle))
        //        //    query = query.Where(x => x.VehicleNo.Contains(filter.Vehicle));

        //        if (!string.IsNullOrEmpty(filter.InvoiceNo))
        //            query = query.Where(x => x.RMTInvoiceNo.Contains(filter.InvoiceNo));

        //        if (!string.IsNullOrEmpty(filter.LrNo))
        //            query = query.Where(x => x.LrNo.Contains(filter.LrNo));

        //        if (filter.FromDate != null && filter.FromDate.ToString() != "")
        //            query = query.Where(x => x.InvoiceDate >= filter.FromDate);

        //        if (filter.ToDate != null && filter.ToDate.ToString() != "")
        //            query = query.Where(x => x.InvoiceDate <= filter.ToDate);
        //        var result = query.OrderBy(x => x.RMTInvoiceNo).ToList();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while fetching invoice report.");
        //        return StatusCode(500, "An error occurred while retrieving data.");
        //    }
        //}

        [HttpGet("GetInvoiceReport")]
        public IActionResult GetInvoiceReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try
            {
                var query =
                    from b in _context.BillTransaction
                    join bd in _context.BillItemDetails on b.Id equals bd.BTId
                    join t in _context.TripTransaction on bd.TripId equals t.Id
                    join c in _context.Customers on b.CustomerId equals c.Id
                    join v in _context.Vehilces on t.VehicleId equals v.Id
                    join d in _context.Locations on bd.DestinationId equals d.Id

                    join tc in _context.TripConsigneeDetails
                        on t.Id equals tc.Id into tcGroup
                    from tc in tcGroup.DefaultIfEmpty()

                    join cc in _context.Customers
                        on tc.ToConsigneeId equals cc.Id into ccGroup
                    from cc in ccGroup.DefaultIfEmpty()

                    where b.IsDeleted != true
                          && !string.IsNullOrEmpty(b.status)
                          && t.Status != "Cancelled"

                    select new
                    {
                        b.Id,
                        InvoiceNo = b.RMTInvoiceNo,
                        b.BillDate,
                        b.CustomerId,

                        CustomerName = c.Name,
                        CustomerAddress = c.Address,
                        CustomerPhoneNo = c.Phone,
                        CustomerEmail = c.Email,
                        CustomerGST = c.GSTNo,
                        CustomerPanNo = c.PanNo,
                        InvoiceTemplateName = c.InvoiceTemplateName,

                        LrNo = t.ReferenceNo,
                        t.LRDate,
                        t.StartDate,
                        t.ExpectedDeliveryDate,
                        t.ActualDeliveryDate,

                        b.status,
                        t.Notes,
                        t.LoadingCost,
                        CommissionAmount = t.CommissionAmt,
                        AdditionalAmount = t.AdditionalCost,
                        TotalAmount = t.TotalCost,

                        VehicleNo = v.Name,
                        FreightCharges = t.FrieghtCharges,
                        b.GrandAmount,

                        ConsigneeName = cc != null ? cc.Name : "",
                        LocationName = d.Name
                    };

                if (!string.IsNullOrWhiteSpace(filter.Customer))
                    query = query.Where(x => x.CustomerName.Contains(filter.Customer));

                if (!string.IsNullOrWhiteSpace(filter.Status))
                    query = query.Where(x => x.status.Contains(filter.Status));

                if (!string.IsNullOrWhiteSpace(filter.InvoiceNo))
                    query = query.Where(x => x.InvoiceNo.ToString().Contains(filter.InvoiceNo));

                if (!string.IsNullOrWhiteSpace(filter.LrNo))
                    query = query.Where(x => x.LrNo.Contains(filter.LrNo));

                if (filter.FromDate.HasValue)
                    query = query.Where(x => x.BillDate >= filter.FromDate.Value);

                if (filter.ToDate.HasValue)
                    query = query.Where(x => x.BillDate <= filter.ToDate.Value);

                var result = query
                    .AsEnumerable()
                    .GroupBy(x => x.Id)
                    .Select(g => new CustomerInvoice
                    {
                        Id = g.Key,
                        InvoiceNo = g.First().InvoiceNo.ToString(),
                        RMTInvoiceNo = g.First().InvoiceNo,
                        InvoiceDate = g.First().BillDate,
                        CustomerId = g.First().CustomerId.ToString(),

                        CustomerName = g.First().CustomerName,
                        CustomerAddress = g.First().CustomerAddress,
                        CustomerPhoneNo = g.First().CustomerPhoneNo,
                        CustomerEmail = g.First().CustomerEmail,
                        CustomerGST = g.First().CustomerGST,
                        CustomerPanNo = g.First().CustomerPanNo,
                        InvoiceTemplateName = g.First().InvoiceTemplateName ?? "",

                        LrNo = g.First().LrNo ?? "",
                        LRDate = g.First().LRDate,
                        StartDate = g.First().StartDate,
                        ExpectedDeliveryDate = g.First().ExpectedDeliveryDate,
                        ActualDeliveryDate = g.First().ActualDeliveryDate ?? DateTime.MinValue,

                        status = g.First().status,
                        Notes = g.First().Notes ?? "",

                        LoadingCost = g.First().LoadingCost,
                        CommissionAmount = g.First().CommissionAmount,
                        AdditionalAmount = g.First().AdditionalAmount,
                        TotalAmount = g.First().TotalAmount,

                        VehicleNo = g.First().VehicleNo,
                        FreightCharges = g.First().FreightCharges ?? 0,

                        TaxPer = 0,
                        TotalTax = 0,
                        GrandAmount = g.First().GrandAmount,

                        ConsigneeName = string.Join(", ",
                            g.Select(x => x.ConsigneeName)
                             .Where(x => !string.IsNullOrWhiteSpace(x))
                             .Distinct()),

                        ToLocationName = string.Join(", ",
                            g.Select(x => x.LocationName)
                             .Where(x => !string.IsNullOrWhiteSpace(x))
                             .Distinct())
                    })
                    .OrderBy(x => x.RMTInvoiceNo)
                    .ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching invoice report.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }


        // GET: api/<BillTransactions>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last invoice code from database.");
            try
            {
                var currentCode = await _context.BillTransaction.Where(f => f.IsDeleted != true).OrderByDescending(p => p.Id).Select(s => s.Code).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for Invoice.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current invoice Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<BillTransactions>
        [HttpGet("GetInvoiceDetail/{invoiceNo}")]
        public async Task<ActionResult<IEnumerable<int>>> GetInvoiceDetails(int invoiceNo)
        {
            _logger.LogInformation("Fetching current/last invoice code from database.");
            try
            {
                var invoiceDetail = await _context.BillTransaction.Where(p => p.IsDeleted != true && p.RMTInvoiceNo == invoiceNo).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched invoice detail for Invoice {invoiceNo}.", invoiceNo);
                return Ok(new { invoiceDetail });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching invoice detail.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }


        // GET: api/<BillTransactions>
        [HttpGet("CurrentRMTInvoiceNo/{yearCode}")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentRMTInvoiceNo(string yearCode)
        {
            _logger.LogInformation("Fetching current/last RMT invoice No from database.");
            try
            {
                var currentCode = await _context.BillTransaction.Where(f => f.YearCode == yearCode && !f.IsDeleted).MaxAsync(p => (int?)p.RMTInvoiceNo) ?? 0;
                _logger.LogInformation("Fetched {currentCode} for Invoice.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current RMT invoice No.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<BillController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bill>> GetCustomerInvoiceById(int id)
        {
            _logger.LogInformation("Fetching customer invoices with ID {Id}.", id);
            try
            {
                var customerInvoices = await _context.BillTransaction
                            .Include(t => t.ProductDetails)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (customerInvoices == null)
                {
                    _logger.LogWarning("customer Invoices with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(customerInvoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer Invocie with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the customer invoice.{ex.StackTrace}");
            }
        }

        // GET api/<BillController>/5
        [HttpGet("GetInvoice/{id}")]
        private async Task<Bill?> GetInvoice(int id)
        {
            _logger.LogInformation("Fetching customer invoices with ID {Id}.", id);
            try
            {
                var customerInvoices = await _context.BillTransaction
                            .Include(t => t.ProductDetails)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (customerInvoices == null)
                {
                    _logger.LogWarning("customer Invoices with ID {Id} not found.", id);
                    return null;
                }

                return customerInvoices;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer Invocie with ID {Id}.", id);
                return null;
            }
        }

        // GET api/<BillController>
        [HttpGet("GetCustomerInvoicePending")]
        public async Task<ActionResult<List<Bill>>> GetCustomerInvoicePending()
        {
            _logger.LogInformation("Fetching customer invoices Pendiong to Invoice");
            try
            {
                var customerInvoices = await _context.BillTransaction
                            .Include(t => t.ProductDetails)
                            .Where(p => p.status == "Completed" && p.IsDeleted != true).ToListAsync();

                if (customerInvoices == null)
                {
                    _logger.LogWarning("customer Invoices pending not found.");
                    return NotFound();
                }

                return Ok(customerInvoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer Invocie pending.");
                return StatusCode(500, $"An error occurred while retrieving the customer pending invoice.{ex.StackTrace}");
            }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var billedInvoices = await _context.BillTransaction
                    .Where(p => p.BillDate >= filter.StartDate &&
                                p.BillDate <= filter.EndDate &&
                                p.AccountStatus != "Posted" &&
                                p.IsDeleted == false &&
                                (p.AccountTransactionId ?? 0) == 0)
                    .ToListAsync();

            if (!billedInvoices.Any())
            {
                return NotFound("No invoices found for the selected date range.");
            }

            foreach (var invoice in billedInvoices)
            {
                if (invoice != null)
                {
                    await _invoiceService.PostInvoiceToAccountsAsync(invoice.Id);
                }
            }

            return Ok(new
            {
                Message = "Invoice posting completed",
                Count = billedInvoices.Count
            });
        }

        [HttpPost("AccountPosting/{billId}")]
        public async Task<IActionResult> PostBillToAccounting(int billId)
        {
            // Load the bill from DB
            var bill = await GetInvoice(billId);
            if (bill == null)
                return NotFound($"Bill with Id {billId} not found.");

            if (bill.AccountStatus == "Posted")
                return BadRequest("Bill is already posted to accounting.");

            // Post to accounting
            await _invoiceService.PostInvoiceToAccountsAsync(bill.Id);

            return Ok(new { BillId = billId });
        }

        // POST api/<BillController>
        [HttpPost]
        public async Task<ActionResult<Bill>> PostInvoices(Bill bill)
        {
            _logger.LogInformation("Creating a new invoice.");


            try
            {
                // Step 1: Save invoice and generate Bill Id
                //await _context.BillTransaction.AddAsync(bill);
                //await _context.SaveChangesAsync();

                var financialYear = await _context.FinancialYears.Where(p => p.Code == bill.YearCode).FirstOrDefaultAsync();
                if (bill.BillDate < financialYear?.FinStartDate || bill.BillDate > financialYear?.FinEndDate)
                {
                    return BadRequest("Transaction date must be within the financial year.");
                }

                // Step 1: Extract bill items
                var billItems = bill.ProductDetails?.ToList();
                bill.ProductDetails = null;

                // Step 2: Save BillTransaction first
                _context.BillTransaction.Add(bill);
                await _context.SaveChangesAsync(); // bill.Id generated

                // Step 3: Save BillItemDetails with BillId
                if (billItems != null && billItems.Any())
                {
                    foreach (var item in billItems)
                    {
                        item.BTId = bill.Id;
                    }

                    await _context.BillItemDetails.AddRangeAsync(billItems);
                    await _context.SaveChangesAsync();
                }


                // Step 2: Extract related Trip IDs from bill details
                var tripIds = billItems?.Where(p => p.TripId > 0)   // avoid invalid IDs
                                   .Select(p => p.TripId)
                                   .Distinct()
                                   .ToList();
                if (tripIds.Any())
                {
                    // Step 3: Fetch trips in ONE query
                    var tripsToUpdate = await _context.TripTransaction
                                                      .Where(t => tripIds.Contains(t.Id))
                                                      .ToListAsync();

                    // Step 4: Update the BillNo on all selected trips
                    tripsToUpdate.ForEach(t => t.BillNo = bill.Id);
                    tripsToUpdate.ForEach(t => t.Status = "Billed");

                    // Step 5: Save trip updates
                    await _context.SaveChangesAsync();

                    var newId = bill.Id;

                    await _invoiceService.PostInvoiceToAccountsAsync(newId);
                }

                _logger.LogInformation("Invoice created successfully with ID {Id}.", bill.Id);

                return CreatedAtAction(nameof(GetCustomerInvoiceById),
                                        new { id = bill.Id }, bill);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new invoice.");
                return StatusCode(500, $"An error occurred while posting the invoice. {ex.Message}");
            }
        }

        // PUT api/<BillController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(int id, Bill bill)
        {
            _logger.LogInformation("Updating invoice with ID {Id}.", id);

            var financialYear = await _context.FinancialYears.Where(p => p.Code == bill.YearCode).FirstOrDefaultAsync();
            if (bill.BillDate < financialYear?.FinStartDate || bill.BillDate > financialYear?.FinEndDate)
            {
                return BadRequest("Transaction date must be within the financial year.");
            }

            if (id != bill.Id)
            {
                _logger.LogWarning("Invoice ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, bill.Id);
                return BadRequest("Invoice ID mismatch");
            }

            // =========================================
            // 1️ Delete AccountTransaction
            // =========================================
            if (bill.AccountStatus == "Posted")
            {
                // Find the transaction by TransactionReferenceId
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == bill.AccountTransactionId);

                if (accountTransaction != null)
                {
                    // Remove the account transaction
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }

            bill.AccountStatus = "Draft";
            bill.AccountTransactionId = 0;
            _context.Entry(bill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();


                //post the transation to accounts
                await _invoiceService.PostInvoiceToAccountsAsync(bill.Id);
                _logger.LogInformation("Invoice with ID {Id} updated successfully.", id);
                return Ok(bill);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!InvoiceExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent invoice with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating invoice with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating invoice with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the customer invoice.{ex.StackTrace}");
            }
        }

        // DELETE api/<BillController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            _logger.LogInformation("Deleting invoice with ID {Id}.", id);
            try
            {
                var bill = await _context.BillTransaction.FindAsync(id);
                if (bill == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent invoice with ID {Id}.", id);
                    return NotFound();
                }
                if (bill.AccountStatus == "verified")
                {
                    var msg = $"Invoice is verified to accounts with {bill.AccountTransactionId}. Invoice cannot be cancelled.";
                    _logger.LogWarning(msg);
                    return BadRequest(new { error = msg });
                }

                if ((bill.AccountTransactionId ?? 0) > 0)
                {
                    // Find the transaction by TransactionReferenceId
                    var accountTransaction = await _context.AccountTransactions
                        .FirstOrDefaultAsync(t => t.Id == bill.AccountTransactionId);

                    if (accountTransaction != null)
                    {
                        // Remove the account transaction
                        _context.AccountTransactions.Remove(accountTransaction);
                        _context.SaveChanges();
                    }
                }

                bill.IsDeleted = true;
                bill.RMTInvoiceNo = 0;
                bill.TotalAmount = 0;
                bill.status = "Deleted";
                var trips = await _context.TripTransaction
                            .Where(t => t.BillNo == id)
                            .ToListAsync();

                trips.ForEach(t => t.BillNo = null);
                trips.ForEach(t => t.Status = "Delivered");
                await _context.SaveChangesAsync();

                _logger.LogInformation("Customer Invoice with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting invoice with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the customer invoice.{ex.StackTrace}");
            }
        }

        private bool InvoiceExists(int id)
        {
            return _context.BillTransaction.Any(e => e.Id == id);
        }
    }
}
