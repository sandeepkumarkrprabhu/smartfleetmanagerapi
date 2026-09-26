using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IAccountStatementService
    {
        Task<List<AccountStatementResult>> GetStatementAsync(AccountStatmentFilterDTO filter);
    }
}
