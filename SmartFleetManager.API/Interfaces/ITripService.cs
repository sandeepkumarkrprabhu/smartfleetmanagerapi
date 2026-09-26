using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface ITripService
    {
        Task<IEnumerable<TripTransactionView>> GetTripsAsync(string yearCode);
        Task<IEnumerable<TripTransactionView>> GetPendingInvoiceTripsAsync();
        Task<IEnumerable<TripTransactionView>> GetRecentTripsAsync();
        Task<IEnumerable<TripReportResultDto>> GetTripReportAsync(TripReportFilterDto filter);
        Task<string?> GetCurrentCodeAsync();
        Task<IEnumerable<TripTransactionView>> GetCustomerPendingOrdersAsync(int id);
        Task<TripTransaction?> GetTripAsync(int id);
        Task<IEnumerable<TripTransaction>> GetTripsAsync(TripReportFilterDto filter);
        Task<IReadOnlyList<TripTransaction>> GetTripsForPostingAsync(PostingFilterDTO filter);
        Task<TripTransaction?> GetTripForPostingAsync(int id);
        Task<TripTransaction> CreateTripAsync(TripTransaction trip);
        Task<bool> UpdateTripAsync(int id, TripTransaction trip);
        Task<bool> DeleteTripAsync(int id);
        Task PostTripToAccountsAsync(int tripId);
        Task UnpostTripAsync(int tripId);
    }
}