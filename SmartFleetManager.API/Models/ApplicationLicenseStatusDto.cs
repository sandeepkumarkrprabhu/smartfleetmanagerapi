namespace SmartFleetManager.API.Models
{
    public class ApplicationLicenseStatusDto
    {
        public bool IsValid { get; set; }
        public string Status { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public DateTime? LicenseValidTill { get; set; }
        public int? RemainingDays { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}