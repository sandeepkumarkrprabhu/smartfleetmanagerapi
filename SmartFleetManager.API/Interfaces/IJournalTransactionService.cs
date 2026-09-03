namespace SmartFleetManager.API.Interfaces
{
    public interface IJournalTransactionService
    {
        Task PostTripToAccountsAsync(int journalId);
        Task UnpostTripAsync(int journalId);
    }
}
