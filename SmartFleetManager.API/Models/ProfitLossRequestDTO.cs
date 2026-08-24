namespace SmartFleetManager.API.Models
{
    public class ProfitLossRequestDTO
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<int>? AccountIds { get; set; }
    }
}
