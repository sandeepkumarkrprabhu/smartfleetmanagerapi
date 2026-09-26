using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IJournalTransactionService
    {
        Task<IEnumerable<JournalEntry>> GetJournalsAsync(string yearCode);
        Task<IEnumerable<JournalEntry>> GetJournalSummaryByYearAsync(int yearCode);
        Task<int> GetCurrentCodeAsync(string yearCode);
        Task<JournalEntry?> GetJournalEntryByIdAsync(int id);
        Task<JournalEntry> CreateJournalEntryAsync(JournalEntry journal);
        Task<JournalEntry?> UpdateJournalEntryAsync(int id, JournalEntry journal);
        Task<bool> DeleteJournalAsync(int id);
        Task PostTripToAccountsAsync(int journalId);
        Task UnpostTripAsync(int journalId);
    }
}
