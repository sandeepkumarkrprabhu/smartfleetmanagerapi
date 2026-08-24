using System.Security.Cryptography.X509Certificates;

namespace SmartFleetManager.API.Models
{
    public class CustomerInvoice
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyEmail { get; set; }

        public int Id { get; set; }
        public string InvoiceNo {get;set; }
        public int RMTInvoiceNo {get; set; }
        public DateTime InvoiceDate { get; set; }
        
        //Billing Customer
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGST { get; set; }
        public string CustomerPanNo { get; set; }

        public string CompanyGst {get;set; }
        public string CompanyPan {get;set; }
        public string CompanySac {get;set;}
        public string InvoiceTemplateName {get; set; }

        public string LrNo {get;set; }
        public DateTime LRDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }

        public string VehicleNo { get; set; }
        public string VehicleType { get; set; }
        public decimal FreightCharges { get; set; }
        public string status { get; set; }
        public string Notes { get; set; }
        
        public decimal LoadingCost  {get;set; }
        public decimal CommissionAmount {get;set; }
        public decimal AdditionalAmount {get;set; }
        public decimal TotalAmount {get;set; }
        public decimal TaxPer {get;set; }
        public decimal TotalTax {get;set; }
        public decimal GrandAmount {get;set; }
        public string ConsigneeName {get;set; }
        public string ToLocationName {get;set; }

        public List<CustomerInvoiceDetail> Details { get; set; }
        public List<CustomerInvoiceConsigneeDetails> ConsigneeDetails { get; set; }
    }
}
