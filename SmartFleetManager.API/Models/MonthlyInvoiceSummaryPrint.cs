namespace SmartFleetManager.API.Models
{
    public class MonthlyInvoiceSummaryPrint
    {

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyGST { get; set; }
        public string CompanyPAN { get; set; }
        public string CompanySACNo { get; set; }

        public string BillNo {get;set; }
        public DateTime BillDate {get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGST { get; set; }
        public string CustomerPAN { get; set; }
        public string InvoiceTemplateName {get; set; }
        public string BillingPeriod { get; set; }

        public int  SlNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string ConsigneeName { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleType { get; set; }
        public int KMS { get; set; }
        public decimal FreightCharges { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal LoadingUnloadingCharges { get; set; }
        public decimal totalAmount { get; set; }
        public string Remarks { get; set; }
        public Boolean IsSalesReturn { get; set; }

        public string LoadingPoint { get; set; }
        public string OffLoadingPoint { get; set; }
   
    }
}
