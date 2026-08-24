namespace SmartFleetManager.API.Models
{
    public class CustomerInvoiceConsigneeDetails
    {
        public string CustomerName { get; set; }
        public string LocationName { get; set; }
        public string LRNo { get; set; }
        public string invoiceNo { get; set; }
        public decimal GoodsValue { get; set; }
    }
}
