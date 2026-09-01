using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;

        public InvoiceService(
            AppDbContext context,
            IAccountTransactionService accountTransactionService)
        {
            _context = context;
            _accountTransactionService = accountTransactionService;
        }

        public async Task PostInvoiceToAccountsAsync(int invoiceId)
        {
            try
            {
                // Get Invoice
                    var invoice = await _context.BillTransaction
                    .FirstOrDefaultAsync(i => i.Id == invoiceId);

                if (invoice == null)
                    throw new Exception("Invoice not found.");

                //accounting status
                if (invoice.AccountStatus == "Posted")
                    throw new Exception("Invoice already posted.");

                // Create Account Transaction
                var transactionId = await _accountTransactionService.CreateInvoiceTransactionAsync(invoice);

                //// 4️ Update Invoice
                invoice.AccountTransactionId = Convert.ToInt32(transactionId);
                invoice.AccountStatus = "Posted";

                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task UnpostInvoiceAsync(int invoiceId)
        {
            var invoice = await _context.BillTransaction
                                        .FirstOrDefaultAsync(x => x.Id == invoiceId);

            if (invoice == null || invoice.AccountTransactionId == null)
                throw new Exception("Invoice not posted.");

            await _accountTransactionService.ReverseTransactionAsync(invoice.AccountTransactionId.Value, "Admin");

            invoice.AccountTransactionId = null;
            invoice.status = "NotPosted";

            await _context.SaveChangesAsync();
        }
    }
}
