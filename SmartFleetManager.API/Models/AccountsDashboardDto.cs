namespace SmartFleetManager.API.Models
{
    public class AccountsDashboardDto
    {
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal CashAndBank { get; set; }
        public decimal ProfitLoss { get; set; }

        public List<MonthlyFinancialDto> MonthlyFinancials { get; set; } = new();
        public List<RecentTransactionDto> RecentTransactions { get; set; } = new();
    }

    public class MonthlyFinancialDto
    {
        public string Month { get; set; } = string.Empty;
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal ProfitLoss { get; set; }
    }

    public class RecentTransactionDto
    {
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
    }
}
