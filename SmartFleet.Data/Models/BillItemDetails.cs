
namespace SmartFleet.Data.Models
{
    public class BillItemDetails
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public string Route { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal LoadingCost { get; set; }
        public decimal CommissionAmt { get; set; }
        public decimal AdditionalCost { get; set; }
        public int MtnNo { get; set; }
        public int Kms { get; set; }
        public string LrNo { get; set; }
        public string code { get; set; }
        public int BTId { get; set; }
    }
}
