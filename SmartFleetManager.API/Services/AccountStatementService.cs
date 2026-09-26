using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class AccountStatementService : IAccountStatementService
    {
        private readonly AppDbContext _context;

        public AccountStatementService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AccountStatementResult>> GetStatementAsync(AccountStatmentFilterDTO filter)
        {
            var transactions = await _context.AccountTransactionDetails
                .Where(d => d.AccountID == filter.AccountId &&
                            d.AccountTransaction.TransactionDate >= filter.startDate &&
                            d.AccountTransaction.TransactionDate <= filter.endDate)
                .OrderBy(d => d.AccountTransaction.TransactionDate)
                .Select(d => new AccountStatementResult
                {
                    Date = d.AccountTransaction.TransactionDate,
                    ReferenceNo = d.AccountTransaction.ReferenceNo,
                    TransactionType = d.AccountTransaction.DocumentType,
                    Description = d.Narration,
                    Debit = d.Debit,
                    Credit = d.Credit
                })
                .ToListAsync();

            decimal runningBalance = 0;

            foreach (var item in transactions)
            {
                runningBalance += item.Debit - item.Credit;
                item.Balance = runningBalance;
            }

            return transactions;
        }
    }
}
