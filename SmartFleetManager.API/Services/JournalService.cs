using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
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
        public async Task PostTripToAccountsAsync(int journalId)
        {
            try
            {
                // Get Invoice
                var journals = await _context.JournalEntries
                .FirstOrDefaultAsync(i => i.JournalEntryId == journalId);

                if (journals == null)
                    throw new Exception("Invoice not found.");

                //accounting status
                if (journals.AccountStatus == "Posted")
                    throw new Exception("Invoice already posted.");

                // Create Account Transaction
                var transactionId = await _accountTransactionService.CreateJournalTransactionAsync(journals);

                //// 4️ Update Invoice
                journals.AccountTransactionId = Convert.ToInt32(transactionId);
                journals.AccountStatus = "Posted";

                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
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
