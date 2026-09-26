using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Services
{
    public class JournalService : IJournalTransactionService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;

        public JournalService(
            AppDbContext context,
            IAccountTransactionService accountTransactionService)
        {
            _context = context;
            _accountTransactionService = accountTransactionService;
        }

        public async Task<IEnumerable<JournalEntry>> GetJournalsAsync(string yearCode)
        {
            return await _context.JournalEntries
                .Where(f => f.YearCode == yearCode)
                .Include(f => f.Lines)
                .ToListAsync();
        }

        public async Task<IEnumerable<JournalEntry>> GetJournalSummaryByYearAsync(int yearCode)
        {
            return await _context.JournalEntries
                .Where(p => p.EntryDate.Year == yearCode)
                .ToListAsync();
        }

        public async Task<int> GetCurrentCodeAsync(string yearCode)
        {
            return await _context.JournalEntries
                .Where(f => f.YearCode == yearCode)
                .OrderByDescending(p => p.JournalEntryId)
                .Select(s => (int?)s.JournalNo)
                .FirstOrDefaultAsync() ?? 0;
        }

        public async Task<JournalEntry?> GetJournalEntryByIdAsync(int id)
        {
            return await _context.JournalEntries
                .Include(t => t.Lines)
                .FirstOrDefaultAsync(t => t.JournalEntryId == id);
        }

        public async Task<JournalEntry> CreateJournalEntryAsync(JournalEntry journal)
        {
            _context.JournalEntries.Add(journal);
            await _context.SaveChangesAsync();

            await PostTripToAccountsAsync(journal.JournalEntryId);

            return journal;
        }

        public async Task<JournalEntry?> UpdateJournalEntryAsync(int id, JournalEntry journal)
        {
            var existingJournal = await _context.JournalEntries
                .Include(j => j.Lines)
                .FirstOrDefaultAsync(j => j.JournalEntryId == id);

            if (existingJournal == null)
                return null;

            if (journal.AccountStatus == "Posted")
            {
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == journal.AccountTransactionId);

                if (accountTransaction != null)
                {
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }

            _context.Entry(existingJournal).CurrentValues.SetValues(journal);

            if (journal.Lines != null)
            {
                foreach (var existingLine in existingJournal.Lines.ToList())
                {
                    if (!journal.Lines.Any(l => l.JournalEntryId == existingLine.JournalEntryId))
                    {
                        _context.JournalEntriesLine.Remove(existingLine);
                    }
                }

                foreach (var line in journal.Lines)
                {
                    var existingLine = existingJournal.Lines
                        .FirstOrDefault(l => l.JournalEntryLineId == line.JournalEntryLineId);

                    if (existingLine != null)
                    {
                        _context.Entry(existingLine).CurrentValues.SetValues(line);
                    }
                    else
                    {
                        existingJournal.Lines.Add(line);
                    }
                }
            }

            await _context.SaveChangesAsync();
            await PostTripToAccountsAsync(existingJournal.JournalEntryId);

            return existingJournal;
        }

        public async Task<bool> DeleteJournalAsync(int id)
        {
            var journal = await _context.JournalEntries.FindAsync(id);
            if (journal == null)
                return false;

            _context.JournalEntries.Remove(journal);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task PostTripToAccountsAsync(int journalId)
        {
            var journals = await _context.JournalEntries
                .FirstOrDefaultAsync(i => i.JournalEntryId == journalId);

            if (journals == null)
                throw new Exception("Invoice not found.");

            if (journals.AccountStatus == "Posted")
                throw new Exception("Invoice already posted.");

            var transactionId = await _accountTransactionService.CreateJournalTransactionAsync(journals);

            journals.AccountTransactionId = Convert.ToInt32(transactionId);
            journals.AccountStatus = "Posted";

            await _context.SaveChangesAsync();
        }

        public async Task UnpostTripAsync(int journalId)
        {
            var journal = await _context.JournalEntries
                .FirstOrDefaultAsync(x => x.JournalEntryId == journalId);

            if (journal == null || journal.AccountTransactionId == null)
                throw new Exception("Journal not posted.");

            await _accountTransactionService.ReverseTransactionAsync(journal.AccountTransactionId.Value, "Admin");

            journal.AccountTransactionId = 0;
            journal.AccountStatus = "Draft";

            await _context.SaveChangesAsync();
        }
    }
}
