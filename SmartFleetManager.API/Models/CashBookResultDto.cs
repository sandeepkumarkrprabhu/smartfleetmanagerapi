namespace SmartFleetManager.API.Models
{
    public class CashBookResultDto
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal OpeningBalance { get; set; }
        public List<CashBookEntryDto> Entries { get; set; } = new();
        public decimal TotalReceipt { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal ClosingBalance { get; set; }
    }

    public class CashBookEntryDto
    {
        public DateTime Date { get; set; }
        public string DocumentType { get; set; } = string.Empty;
        public string ReferenceNo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Receipt { get; set; }
        public decimal Payment { get; set; }
        public decimal Balance { get; set; }
        public int TransactionId { get; set; }
    }
}
