namespace SmartFleetManager.API.Models
{
    public class CustomerInvoiceSummary
    {
        public int SlNo {get;set; }
        public int BillNo {get;set; }
        public DateTime BillDate {get;set;}  
        public int CustomerId {get;set; }
        public string CustomerName {get;set; }
        public string InvoiceTemplateName {get;set; }
        public string LRNo {get;set; }
        public decimal GrandTotal {get;set; }
    }
}
