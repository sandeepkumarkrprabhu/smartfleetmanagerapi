namespace SmartFleetManager.API.Models
{
    public class TrialBalanceReportFilterDTO
    {
        public string FinancialYearCode { get; set; }
        public bool IsIncludeZeroBalanceAcc {get;set; }
        public bool IsShowGroupWise { get; set; }
        public int BranchId { get; set; }
    }
}
