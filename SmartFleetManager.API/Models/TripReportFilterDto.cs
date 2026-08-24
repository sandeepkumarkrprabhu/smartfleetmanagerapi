namespace SmartFleetManager.API.Models
{
    public class TripReportFilterDto
    {
        public string? Stockist {get;set;}
        public string? Customer { get; set; }
        public string? Status { get; set; }
        public string? Driver { get; set; }
        public string? Vehicle { get; set; }
        public string? Vendor { get; set; }
        public string? DocketNo { get; set; }

        public string? InvoiceNo { get; set; }
        public string? LRNo { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
