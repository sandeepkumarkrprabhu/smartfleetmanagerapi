namespace SmartFleetManager.API.Models
{
    public class TripConsigneeDetailsView
    {
        public int Id { get; set; }
        public int ToConsigneeId { get; set; }
        public int DestinationId { get; set; }
        public string LrNo { get; set; }
        public string InvoiceNo { get; set; }
        public decimal GoodsValue { get; set; }
        public decimal FreightCharges { get; set; }
        public string ConsigneeName { get; set; }
        public string DestinationLocationName { get; set; }
    }
}
