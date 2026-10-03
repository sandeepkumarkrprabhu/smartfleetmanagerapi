using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;
using SmartFleet.Utility;

namespace SmartFleetManager.API.Services
{
    public class ApplicationLicenseService : IApplicationLicenseService
    {
        private const int ExpiryWarningDays = 10;
        private readonly AppDbContext _context;

        public ApplicationLicenseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationLicenseStatusDto> GetLicenseStatusAsync()
        {
            var company = await _context.Companies
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (company == null)
            {
                return new ApplicationLicenseStatusDto
                {
                    IsValid = false,
                    Status = "LicenseMissing",
                    Message = "Company details are not configured. Please contact the support team."
                };
            }

            if (string.IsNullOrWhiteSpace(company.LicenseCode))
            {
                return new ApplicationLicenseStatusDto
                {
                    IsValid = false,
                    Status = "LicenseMissing",
                    CompanyName = company.Name,
                    Message = "Product license is missing. Please contact the support team."
                };
            }

            var validation = ProductValidateHelper.ValidateProductKeyWithMessage(
                company.LicenseCode,
                company.Name);

            if (!validation.ValidateStatus)
            {
                var isExpired = validation.validTillDate is not null
                    && DateTime.TryParse(validation.validTillDate, out var validTill)
                    && validTill < DateTime.Now;

                return new ApplicationLicenseStatusDto
                {
                    IsValid = false,
                    Status = isExpired ? "Expired" : "Invalid",
                    CompanyName = company.Name,
                    LicenseValidTill = isExpired ? validTill : null,
                    RemainingDays = isExpired ? 0 : null,
                    Message = isExpired
                        ? "Your product license has expired. Please contact the support team for renewal."
                        : validation.ValidateMessge
                };
            }

            DateTime? licenseValidTill = null;

            if (DateTime.TryParse(validation.validTillDate, out var parsedValidTill))
            {
                licenseValidTill = parsedValidTill;
            }

            var remainingDays = Math.Max(validation.BalanceRenewalDays, 0);
            var isExpiringSoon = remainingDays <= ExpiryWarningDays;

            return new ApplicationLicenseStatusDto
            {
                IsValid = true,
                Status = isExpiringSoon ? "ExpiringSoon" : "Active",
                CompanyName = company.Name,
                LicenseValidTill = licenseValidTill,
                RemainingDays = remainingDays,
                Message = isExpiringSoon
                    ? $"Your license will expire in {remainingDays} days. Please contact the support team for renewal."
                    : $"The product is licensed to {company.Name}."
            };
        }
    }
}