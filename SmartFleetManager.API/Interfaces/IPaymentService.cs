using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<Payment>> GetPaymentsAsync(string yearCode);
        Task<IEnumerable<Payment>> GetPaymentsByYearAsync();
        Task<int> GetCurrentCodeAsync(string yearCode);
        Task<Payment?> GetPaymentByIdAsync(int id);
        Task<IReadOnlyList<Payment>> GetPaymentsForPostingAsync(PostingFilterDTO filter);
        Task<Payment?> GetPaymentForPostingAsync(int id);
        Task<Payment> CreatePaymentAsync(Payment payment);
        Task<Payment?> UpdatePaymentAsync(int id, Payment payment);
        Task<bool> DeletePaymentAsync(int id);
        Task PostPaymentToAccountsAsync(int paymentId);
    }
}
