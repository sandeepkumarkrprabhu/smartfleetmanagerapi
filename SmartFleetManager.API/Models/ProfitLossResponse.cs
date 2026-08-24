namespace SmartFleetManager.API.Models
{
    public class ProfitLossResponse
    {
        public List<PLItem> Income { get; set; }
        public List<PLItem> Expenses { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal NetProfit { get; set; }
    }
}
