namespace SmartFleetManager.API.Models
{
    public class AccountsDashboardFilterDto
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int? BranchId { get; set; }

        public string? YearCode { get; set; }
    }
}
