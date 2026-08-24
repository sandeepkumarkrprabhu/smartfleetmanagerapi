using SmartFleet.Data.Models;
using System.Security.Cryptography.X509Certificates;

namespace SmartFleetManager.API.Models
{
    public class TripTransactionView
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public string LrNo { get; set; }
        public DateTime LRDate { get; set; }
        public string FromStockist { get; set; }
        public string FromCustomer { get; set; }
        public string ToCustomer { get; set; }
        public int VehicleId { get; set; }
        public string Vehicle { get; set; }
        public int VendorId { get; set; }
        public string Vendor { get; set; }
        public decimal VendorRentCharges { get; set; }
        public int EmployeeId { get; set; }
        public string Employee { get; set; }
        public string InvoiceNo { get; set; }
        public string Route { get; set; }
        public int OriginId { get; set; }
        public string Origin { get; set; }
        public int DestinationId { get; set; }
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string Status { get; set; }
        public int ProductCount { get; set; }
        public string Notes { get; set; }
        public string ReferenceNo {get;set; }
        public int? Mtn {get;set; } = 0;
        public int? Kms {get;set; } = 0;
        public decimal AdditionalCost { get; set; }
        public decimal CommissionAmount { get; set; }
        public decimal LoadingCost { get; set; }
        public decimal TotalCost { get; set; }
        public int? billNo {get;set; }
        public decimal FreightCost {get;set; }

        public decimal TaxPer {get;set; }
        public decimal IGST {get;set; }
        public decimal CGST {get;set; }
        public decimal SGST {get;set; }
        public decimal TotalTax {get;set; }
        public bool IsReceiptReceived { get; set; }
        public int TransactionReferenceId { get; set; }
        public string TransactionStatus { get; set; }

        public TripProductDetail ProductDetails { get; set; }
        public List<TripConsigneeDetailsView> ConsigneeDetails { get; set; }
    }
}
