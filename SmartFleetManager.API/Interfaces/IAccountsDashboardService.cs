using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IAccountsDashboardService
    {
        Task<AccountsDashboardDto> GetDashboardAsync(
            AccountsDashboardFilterDto filter);
    }
}
