namespace SmartFleetManager.API.Models
{
    public class AccountStatmentFilterDTO
    {
        public int AccountId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool IncludeOpeningBalance { get; set; }
    }
}
