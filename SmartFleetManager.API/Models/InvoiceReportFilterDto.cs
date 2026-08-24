namespace SmartFleetManager.API.Models
{
    public class InvoiceReportFilterDto
    {
        public string? Customer { get; set; }
        public string? Driver { get; set; }
        public string? Vehicle { get; set; }
        public string? LrNo { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Status { get; set; }
        
        
    }
}
