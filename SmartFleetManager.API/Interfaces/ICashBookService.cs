using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface ICashBookService
    {
        Task<CashBookResultDto> GetCashBookAsync(CashBookFilterDto filter);
    }
}
