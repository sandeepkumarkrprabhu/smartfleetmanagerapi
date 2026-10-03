using System.ComponentModel.DataAnnotations;

namespace SmartFleetManager.API.Models
{
    public class UpdateCompanyLicenseRequest
    {
        [Required]
        public string LicenseCode { get; set; } = string.Empty;
    }
}