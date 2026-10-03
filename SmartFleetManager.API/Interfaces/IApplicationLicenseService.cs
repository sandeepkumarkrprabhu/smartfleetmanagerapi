using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IApplicationLicenseService
    {
        Task<ApplicationLicenseStatusDto> GetLicenseStatusAsync();
        Task<ApplicationLicenseStatusDto?> UpdateCompanyLicenseAsync(string licenseCode);
    }
}