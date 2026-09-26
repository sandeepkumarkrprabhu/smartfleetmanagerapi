using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IReceiptService
    {
        Task<IEnumerable<Receipt>> GetReceiptsAsync(string yearCode);
        Task<IEnumerable<Receipt>> GetReceiptsByYearAsync();
        Task<Receipt?> GetReceiptByIdAsync(int id);
        Task<Receipt?> GetReceiptForPostingAsync(int id);
        Task<int> GetCurrentCodeAsync(string yearCode);
        Task<IReadOnlyList<Receipt>> GetReceiptsForPostingAsync(PostingFilterDTO filter);
        Task<Receipt> CreateReceiptAsync(Receipt receipt);
        Task<Receipt?> UpdateReceiptAsync(int id, Receipt receipt);
        Task<bool> DeleteReceiptAsync(int id);
        Task PostReceiptToAccountsAsync(int receiptId);
    }
}