namespace SmartFleetManager.API.Models
{
    public class CashBookFilterDto
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int AccountId { get; set; }
        public int? BranchId { get; set; }
        public string? YearCode { get; set; }
        public string? DocumentType { get; set; }
        public string? ReferenceNo { get; set; }
        public bool IncludeOpeningBalance { get; set; } = true;
    }
}
