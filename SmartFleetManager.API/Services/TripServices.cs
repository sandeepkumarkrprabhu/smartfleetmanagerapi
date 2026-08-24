using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Services
{
    public class TripServices : ITripService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;
        private readonly ILogger<TripServices> _logger;

        public TripServices(AppDbContext context,
            IAccountTransactionService accountTransactionService, ILogger<TripServices> logger)
        {
            _context = context;
            _logger = logger;
            _accountTransactionService = accountTransactionService;
        }

        public async Task PostTripToAccountsAsync(int tripId)
        {
            // Get Invoice
            var trip = await _context.TripTransaction
                .FirstOrDefaultAsync(i => i.Id == tripId);

            if (trip == null)
                throw new Exception("Trip not found.");

            try
            {
                //  Business Validation
                if (trip.Status != "Delivered" && trip.Status != "Billed")
                {
                    _logger.LogError($"Trip posting failed for LR No: {trip.ReferenceNo} dated {trip.LRDate} for route {trip.Route} with status {trip.Status}");
                    throw new Exception("Only delivered or billed trips can be posted.");
                }

                // Create Account Transaction
                var transactionId = await _accountTransactionService.CreateTripTransactionAsync(trip);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Trip posting failed for LR No: {trip.ReferenceNo} dated {trip.LRDate} for route {trip.Route}");
            }
        }

        public async Task UnpostTripAsync(int invoiceId)
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
