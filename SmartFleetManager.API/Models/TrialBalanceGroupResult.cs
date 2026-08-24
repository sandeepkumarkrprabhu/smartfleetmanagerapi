namespace SmartFleetManager.API.Models
{
    public class TrialBalanceGroupResult
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public decimal TotalDebit { get; set; }
        public decimal TotalCredit { get; set; }

        public List<TrialBalanceReportResult> Accounts { get; set; }
    }
}
