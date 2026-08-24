namespace SmartFleetManager.API.Models
{
    public class CustomerInvoiceGSTSummaryResult
    {
        public int SlNo {get;set; }
        public int BillNo {get;set; }
        public DateTime BillDate {get;set;}  
        public int CustomerID {get;set;}
        public string CustomerName {get;set;}
        public string Place {get;set;}
        public string GSTNo {get;set;}
        public decimal Amount {get;set; }
        public decimal IGST {get;set; }
        public decimal SGST {get;set; }
        public decimal CGST {get;set; }
        public decimal Total {get;set; }
    }
}
