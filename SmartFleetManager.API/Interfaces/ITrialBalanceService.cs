using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface ITrialBalanceService
    {
        Task<List<TrialBalanceGroupResult>> GetTrialBalanceAsync(TrialBalanceReportFilterDTO filter);
    }
}
