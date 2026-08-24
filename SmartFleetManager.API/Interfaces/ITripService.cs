namespace SmartFleetManager.API.Interfaces
{
    public interface ITripService
    {
        Task PostTripToAccountsAsync(int invoiceId);
        Task UnpostTripAsync(int invoiceId);
    }
}
