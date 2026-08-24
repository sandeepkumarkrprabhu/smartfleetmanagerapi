namespace SmartFleetManager.API.Models
{
    public class TrialBalanceReportResult
    {
        public int slNo { get; set; }

        public int AccountID { get; set; }

        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal DebitAmt { get; set; }
        public decimal CreditAmt { get; set; }
    }
}
