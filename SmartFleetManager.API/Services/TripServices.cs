using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;
using System.Net.NetworkInformation;

namespace SmartFleetManager.API.Services
{
    public class TripServices : ITripService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;
        private readonly ILogger<TripServices> _logger;

        public TripServices(AppDbContext context, IAccountTransactionService accountTransactionService, ILogger<TripServices> logger)
        {
            _context = context;
            _accountTransactionService = accountTransactionService;
            _logger = logger;
        }

        public async Task<IEnumerable<TripTransactionView>> GetTripsAsync(string yearCode)
        {
            var trips = from t in _context.TripTransaction
                        join fC in _context.Customers on t.StockistID equals fC.Id
                        join tC in _context.Customers on t.ToCustomerId equals tC.Id
                        join v in _context.Vehilces on t.VehicleId equals v.Id
                        join ve in _context.Vendors on t.VendorId equals ve.Id
                        join e in _context.Employees on t.EmployeeId equals e.Id
                        join o in _context.Locations on t.OriginId equals o.Id
                        join d in _context.Locations on t.DestinationId equals d.Id
                        where t.Status != "Cancelled" && t.YearCode == yearCode
                        select new TripTransactionView
                        {
                            Id=t.Id, Code=t.Code, FromCustomer=fC.Name, ToCustomer=tC.Name, Vehicle=v.Name, Vendor=ve.Name,
                            VendorRentCharges=t.VendorRentCharges??0, Employee=e.Name, LRDate=t.LRDate, Route=t.Route??"",
                            Origin=o.Name, Destination=d.Name, StartDate=t.StartDate, ExpectedDeliveryDate=t.ExpectedDeliveryDate,
                            Status=t.Status??"Planned", ProductCount=t.ProductCount, Notes=t.Notes??"", ReferenceNo=t.ReferenceNo??"",
                            Mtn=t.MtnNo??0, Kms=t.Kms??0, FreightCost=t.FrieghtCharges??0, TotalCost=t.finalAmount??0,
                            IsReceiptReceived=t.IsReceiptReceived, TransactionReferenceId=t.TransactionReferenceId,
                            TransactionStatus=t.TransactionStatus??"",
                            ConsigneeDetails=(from tc in _context.TripConsigneeDetails
                                              join c in _context.Customers on tc.ToConsigneeId equals c.Id
                                              join d in _context.Locations on tc.DestinationId equals d.Id
                                              where tc.TripTransactionId==t.Id
                                              select new TripConsigneeDetailsView
                                              { Id=tc.Id, ToConsigneeId=tc.ToConsigneeId, DestinationId=tc.DestinationId,
                                                ConsigneeName=c.Name, DestinationLocationName=d.Name, LrNo=tc.LRNo??"",
                                                InvoiceNo=tc.InvoiceNo??"", GoodsValue=tc.GoodsValue??0, FreightCharges=tc.FreightCharges }).ToList()
                        };
            var result=await trips.ToListAsync();
            foreach(var trip in result) {
                trip.LrNo=string.Join(", ",trip.ConsigneeDetails.Select(x=>x.LrNo).Where(x=>!string.IsNullOrWhiteSpace(x)).Distinct());
                trip.InvoiceNo=string.Join(", ",trip.ConsigneeDetails.Select(x=>x.InvoiceNo).Where(x=>!string.IsNullOrWhiteSpace(x)).Distinct());
            }
            return result.OrderByDescending(x=>x.LRDate);
        }

        public async Task<IEnumerable<TripTransactionView>> GetPendingInvoiceTripsAsync()
        {
            return await (from t in _context.TripTransaction
                          join fC in _context.Customers on t.FromCustomerId equals fC.Id
                          join tC in _context.Customers on t.ToCustomerId equals tC.Id
                          join v in _context.Vehilces on t.VehicleId equals v.Id
                          join ve in _context.Vendors on t.VendorId equals ve.Id
                          join e in _context.Employees on t.EmployeeId equals e.Id
                          join o in _context.Locations on t.OriginId equals o.Id
                          join d in _context.Locations on t.DestinationId equals d.Id
                          where t.Status=="Delivered"
                          select new TripTransactionView {
                              Id=t.Id, Code=t.Code, FromCustomer=t.IsSalesReturnTrip?tC.Name:fC.Name, ToCustomer=t.IsSalesReturnTrip?fC.Name:tC.Name,
                              Vehicle=v.Name, Vendor=ve.Name, VendorRentCharges=t.VendorRentCharges??0, Employee=e.Name, Route=t.Route??"",
                              Origin=o.Name, Destination=d.Name, StartDate=t.StartDate, ExpectedDeliveryDate=t.ExpectedDeliveryDate,
                              Status=t.Status??"Planned", ProductCount=1, Notes=t.Notes??"", ReferenceNo=t.ReferenceNo??"",
                              Mtn=t.MtnNo??0,Kms=t.Kms??0,FreightCost=t.FrieghtCharges??0,IsReceiptReceived=t.IsReceiptReceived
                          }).ToListAsync();
        }

        public async Task<IEnumerable<TripTransactionView>> GetRecentTripsAsync()
        {
            return await (from t in _context.TripTransaction
                          join fC in _context.Customers on t.FromCustomerId equals fC.Id
                          join tC in _context.Customers on t.ToCustomerId equals tC.Id
                          join v in _context.Vehilces on t.VehicleId equals v.Id
                          join ve in _context.Vendors on t.VendorId equals ve.Id
                          join e in _context.Employees on t.EmployeeId equals e.Id
                          join o in _context.Locations on t.OriginId equals o.Id
                          join d in _context.Locations on t.DestinationId equals d.Id
                          where t.Status!="Cancelled"
                          select new TripTransactionView {
                              Id=t.Id,Code=t.Code,FromCustomer=fC.Name,ToCustomer=tC.Name,Vehicle=v.Name,Vendor=ve.Name,
                              VendorRentCharges=t.VendorRentCharges??0,Employee=e.Name,LrNo=t.ReferenceNo??"",LRDate=t.LRDate,
                              InvoiceNo=t.InvoiceNo??"",Route=t.Route??"",Origin=o.Name,Destination=d.Name,StartDate=t.StartDate,
                              ExpectedDeliveryDate=t.ExpectedDeliveryDate,Status=t.Status??"Planned",ProductCount=t.ProductCount,
                              Notes=t.Notes??"",ReferenceNo=t.ReferenceNo??"",IsReceiptReceived=t.IsReceiptReceived,Mtn=t.MtnNo??0,Kms=t.Kms??0
                          }).OrderByDescending(p=>p.LRDate).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<TripReportResultDto>> GetTripReportAsync(TripReportFilterDto filter)
        {
            var query=from t in _context.TripTransaction
                      join c in _context.Customers on t.FromCustomerId equals c.Id
                      join s in _context.Customers on t.StockistID equals s.Id
                      join d in _context.Employees on t.EmployeeId equals d.Id
                      join v in _context.Vehilces on t.VehicleId equals v.Id
                      join ve in _context.Vendors on t.VendorId equals ve.Id
                      join fl in _context.Locations on t.OriginId equals fl.Id
                      join tl in _context.Locations on t.DestinationId equals tl.Id
                      where t.Status!="Cancelled"
                      select new TripReportResultDto {
                          LRNo=string.Join("/ ",_context.TripConsigneeDetails.Where(x=>x.TripTransactionId==t.Id&&x.LRNo!=null).Select(x=>x.LRNo)),
                          LRDate=t.LRDate,
                          RmtInvoiceNo=string.Join(", ",_context.TripConsigneeDetails.Where(x=>x.TripTransactionId==t.Id&&x.InvoiceNo!=null).Select(x=>x.InvoiceNo)),
                          ConsigneeName=string.Join(Environment.NewLine,_context.TripConsigneeDetails.Where(x=>x.TripTransactionId==t.Id).Select(x=>(x.ToConsignee!=null?x.ToConsignee.Name:"")+" - "+(x.Destination!=null?x.Destination.Name:""))),
                          status = t.Status??"",VehicleNo=v.Name,VehicleType=v.VehicleType,Vendor=ve.Name,VendorRentCharges=t.VendorRentCharges??0,
                          FromLocation=fl.Name,ToLocation=tl.Name,StockistName=s.Name,CustomerName=c.Name,DriverName=d.Name,MTN=t.MtnNo,KMS=t.Kms,
                          Commission=t.CommissionAmt,GoodsValue=t.GoodsValue??0,LRCharges=t.LRCharges??0,HaltingCharges=t.HaltingCharges??0,
                          HandlingCharges=t.HandlingCharges??0,FreightCharges=t.FrieghtCharges??0,DriverCharges=t.DriverBata,FuelCharges=t.FuelCharges,
                          TollCharges=t.TollCharges,TotalCost=t.TotalCost,Notes=t.Notes??""
                      };
            if(!string.IsNullOrEmpty(filter.Stockist)) query=query.Where(x=>x.StockistName.ToLower().StartsWith(filter.Stockist.ToLower()));
            if(!string.IsNullOrEmpty(filter.Customer)) query=query.Where(x=>x.CustomerName.ToLower().StartsWith(filter.Customer.ToLower()));
            if(!string.IsNullOrEmpty(filter.Status)) query=query.Where(x=>x.status.ToLower().Contains(filter.Status.ToLower()));
            if(!string.IsNullOrEmpty(filter.Driver)) query=query.Where(x=>x.DriverName.ToLower().StartsWith(filter.Driver.ToLower()));
            if(!string.IsNullOrEmpty(filter.Vehicle)) query=query.Where(x=>x.VehicleNo.Contains(filter.Vehicle));
            if(!string.IsNullOrEmpty(filter.Vendor)) query=query.Where(x=>x.Vendor.ToLower().StartsWith(filter.Vendor.ToLower()));
            if(!string.IsNullOrEmpty(filter.DocketNo)) query=query.Where(x=>x.RmtInvoiceNo.Contains(filter.DocketNo));
            if(!string.IsNullOrEmpty(filter.LRNo)) query=query.Where(x=>x.LRNo.Contains(filter.LRNo));
            if(filter.FromDate!=null) query=query.Where(x=>x.LRDate>=filter.FromDate);
            if(filter.ToDate!=null) query=query.Where(x=>x.LRDate<=filter.ToDate);
            return await query.OrderBy(x=>x.LRDate).ToListAsync();
        }

        public async Task<string?> GetCurrentCodeAsync() => await _context.TripTransaction.OrderByDescending(p=>p.Id).Select(s=>s.Code).FirstOrDefaultAsync();

        public async Task<IEnumerable<TripTransactionView>> GetCustomerPendingOrdersAsync(int id)
        {
            return await (from t in _context.TripTransaction
                          join sC in _context.Customers on t.StockistID equals sC.Id
                          join tC in _context.Customers on t.ToCustomerId equals tC.Id
                          join v in _context.Vehilces on t.VehicleId equals v.Id
                          join ve in _context.Vendors on t.VendorId equals ve.Id
                          join e in _context.Employees on t.EmployeeId equals e.Id
                          join o in _context.Locations on t.OriginId equals o.Id
                          join d in _context.Locations on t.DestinationId equals d.Id
                          where t.Status=="Delivered" && (t.BillNo??0)==0 && t.StockistID==id
                          select new TripTransactionView {
                              Id=t.Id,LrNo=t.ReferenceNo??"",InvoiceNo=t.InvoiceNo??"",LRDate=t.LRDate,Code=t.Code,ToCustomer=tC.Name,
                              VehicleId=t.VehicleId,VendorId=t.VendorId??0,VendorRentCharges=t.VendorRentCharges??0,Vehicle=v.Name,Vendor=ve.Name,
                              EmployeeId=t.EmployeeId,Employee=e.Name,Route=t.Route??"",OriginId=t.OriginId,Origin=o.Name,DestinationId=t.DestinationId,
                              Destination=d.Name,StartDate=t.StartDate,ExpectedDeliveryDate=t.ExpectedDeliveryDate,Status=t.Status??"Scheduled",
                              ProductCount=t.ProductCount,Notes=t.Notes??"",ReferenceNo=t.ReferenceNo??"",Mtn=t.MtnNo??0,Kms=t.Kms??0,
                              FreightCost=t.FrieghtCharges??0,AdditionalCost=t.AdditionalCost,CommissionAmount=t.CommissionAmt,LoadingCost=t.LoadingCost,
                              TotalCost=t.TotalCost,TaxPer=t.TaxPercentage??0,CGST=t.CGSTAmount??0,SGST=t.SGSTAmount??0,IGST=t.IGSTAmount??0,
                              billNo=t.BillNo??0,IsReceiptReceived=t.IsReceiptReceived
                          }).ToListAsync();
        }

        public async Task<TripTransaction?> GetTripAsync(int id) => await _context.TripTransaction.Include(c=>c.ConsigneeDetails).Where(t=>t.Status!="Cancelled").FirstOrDefaultAsync(t=>t.Id==id);

        public async Task<IEnumerable<TripTransaction>> GetTripsAsync(TripReportFilterDto filter)
        {
            var query=_context.TripTransaction.Where(f=>f.Status!="Cancelled").AsQueryable();
            if(!string.IsNullOrEmpty(filter.Customer)) query=query.Where(x=>x.FromCustomer.Name.Contains(filter.Customer));
            if(!string.IsNullOrEmpty(filter.Customer)) query=query.Where(x=>x.ToCustomer.Name.Contains(filter.Customer));
            if(!string.IsNullOrEmpty(filter.Status)) query=query.Where(x=>x.Status==filter.Status);
            if(!string.IsNullOrEmpty(filter.DocketNo)) query=query.Where(x=>x.InvoiceNo!=null&&x.InvoiceNo.Contains(filter.InvoiceNo));
            if(!string.IsNullOrEmpty(filter.DocketNo)) query=query.Where(x=>x.ReferenceNo!=null&&x.ReferenceNo.Contains(filter.DocketNo));
            if(filter.FromDate!=null) query=query.Where(x=>x.StartDate>=filter.FromDate);
            if(filter.FromDate!=null) query=query.Where(x=>x.ExpectedDeliveryDate<=filter.ToDate);
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<TripTransaction>> GetTripsForPostingAsync(PostingFilterDTO filter) =>
            await _context.TripTransaction.Where(p=>p.LRDate>=filter.StartDate&&p.LRDate<=filter.EndDate&&(p.Status=="Delivered"||p.Status=="Billed")&&(p.TransactionStatus=="Draft"||string.IsNullOrEmpty(p.TransactionStatus))&&((p.VendorRentCharges??0)>0||p.DriverBata>0)).ToListAsync();

        public async Task<TripTransaction?> GetTripForPostingAsync(int id) => await _context.TripTransaction.FirstOrDefaultAsync(x=>x.Id==id);

        public async Task<TripTransaction> CreateTripAsync(TripTransaction trip)
        {
            var lrNo=trip.ReferenceNo?.Trim();
            if(string.IsNullOrWhiteSpace(lrNo)) throw new ArgumentException("trip LR No is required.");
            if(await _context.TripConsigneeDetails.AnyAsync(c=>c.LRNo == lrNo)) throw new InvalidOperationException("trip with LR No already exists.");
            _context.TripTransaction.Add(trip);
            await _context.SaveChangesAsync();
            await PostTripToAccountsAsync(trip.Id);
            return trip;
        }

        public async Task<bool> UpdateTripAsync(int id, TripTransaction trip)
        {
            var existingTrip=await _context.TripTransaction.Include(t=>t.ConsigneeDetails).FirstOrDefaultAsync(t=>t.Id==id);
            if(existingTrip==null) return false;
            if(trip.TransactionStatus=="Posted") {
                var accountTransaction=await _context.AccountTransactions.FirstOrDefaultAsync(t=>t.Id==trip.TransactionReferenceId);
                if(accountTransaction!=null){ _context.AccountTransactions.Remove(accountTransaction); await _context.SaveChangesAsync(); }
            }
            trip.TransactionReferenceId=0; trip.TransactionStatus="Planned";
            _context.Entry(existingTrip).CurrentValues.SetValues(trip);
            if(trip.ConsigneeDetails!=null) {
                foreach(var existing in existingTrip.ConsigneeDetails.ToList())
                    if(!trip.ConsigneeDetails.Any(c=>c.Id==existing.Id)) _context.Remove(existing);
                foreach(var incoming in trip.ConsigneeDetails) {
                    var existing=existingTrip.ConsigneeDetails.FirstOrDefault(c=>c.Id==incoming.Id);
                    if(existing!=null) {
                        existing.LRNo=incoming.LRNo; existing.InvoiceNo=incoming.InvoiceNo; existing.ToConsigneeId=incoming.ToConsigneeId;
                        existing.DestinationId=incoming.DestinationId; existing.ProductId=incoming.ProductId; existing.UnitId=incoming.UnitId;
                        existing.Qty=incoming.Qty; existing.GoodsValue=incoming.GoodsValue; existing.FreightCharges=incoming.FreightCharges;
                    } else existingTrip.ConsigneeDetails.Add(new TripConsigneeDetails {
                        LRNo=incoming.LRNo,InvoiceNo=incoming.InvoiceNo,ToConsigneeId=incoming.ToConsigneeId,DestinationId=incoming.DestinationId,
                        ProductId=incoming.ProductId,UnitId=incoming.UnitId,Qty=incoming.Qty,GoodsValue=incoming.GoodsValue,FreightCharges=incoming.FreightCharges
                    });
                }
            }
            await _context.SaveChangesAsync();
            await PostTripToAccountsAsync(id);
            return true;
        }

        public async Task<bool> DeleteTripAsync(int id)
        {
            var selectedTrip=await _context.TripTransaction.FindAsync(id);
            if(selectedTrip==null) return false;
            if(await _context.BillItemDetails.AnyAsync(p=>p.TripId==id)) return false;
            if(selectedTrip.TransactionStatus=="Posted") {
                var accountTransaction=await _context.AccountTransactions.FirstOrDefaultAsync(t=>t.Id==selectedTrip.Id);
                if(accountTransaction!=null){ _context.AccountTransactions.Remove(accountTransaction); await _context.SaveChangesAsync(); }
            }
            selectedTrip.Status="Cancelled";
            selectedTrip.Notes=$"LR:{selectedTrip.ReferenceNo}, Invoice No:{selectedTrip.InvoiceNo}";
            selectedTrip.ReferenceNo="0"; selectedTrip.InvoiceNo="";
            var details=await _context.TripConsigneeDetails.Where(x=>x.TripTransactionId==id).ToListAsync();
            foreach(var detail in details){ detail.InvoiceNo=""; detail.LRNo="0"; }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task PostTripToAccountsAsync(int tripId)
        {
            var trip=await _context.TripTransaction.FirstOrDefaultAsync(i=>i.Id==tripId);
            if(trip==null) throw new Exception("Trip not found.");
            if(trip.Status!="Delivered"&&trip.Status!="Billed") throw new Exception("Only delivered or billed trips can be posted.");
            await _accountTransactionService.CreateTripTransactionAsync(trip);
        }

        public async Task UnpostTripAsync(int tripId)
        {
            var trip=await _context.TripTransaction.FirstOrDefaultAsync(x=>x.Id==tripId);
            if(trip==null||trip.TransactionReferenceId == 0) throw new Exception("Trip not posted.");
            await _accountTransactionService.ReverseTransactionAsync(trip.TransactionReferenceId,"Admin");
            trip.TransactionReferenceId=0; trip.TransactionStatus="NotPosted";
            await _context.SaveChangesAsync();
        }
    }
}