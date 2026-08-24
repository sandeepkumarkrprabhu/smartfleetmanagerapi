namespace SmartFleetManager.API.Models
{
    public class VehicleRentAgreementViewModel
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int VehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public DateTime RentFromDate { get; set; }
        public DateTime RentToDate { get; set; }
        public Decimal RentAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime Createdon {get;set; }

    }
}
