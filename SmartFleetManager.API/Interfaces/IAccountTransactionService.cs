using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IAccountTransactionService
    {
        Task<long> CreateTransactionAsync(
        AccountTransaction transaction,
        List<AccountTransactionDetail> details);

        Task<long> CreateInvoiceTransactionAsync(Bill invoice);
        Task<long> CreateTripTransactionAsync(TripTransaction trip);

        Task<long> CreateReceiptTransactionAsync(Receipt receipt);

        Task<long> CreatePaymentTransactionAsync(Payment payment);

        Task<long> CreateJournalTransactionAsync(JournalEntry journal);

        Task<long> ReverseTransactionAsync(int transactionId, string reversedBy);

        Task<AccountTransaction> GetTransactionByIdAsync(long transactionId);

        Task ValidateBalancedAsync(List<AccountTransactionDetail> details);

        Task ValidateFinancialYearAsync(string yearCode, DateTime transactionDate);
    }
}
