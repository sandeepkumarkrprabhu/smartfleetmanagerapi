using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _transactionService;
        private readonly ILogger<PaymentService> _logger;

        public PaymentService(
            AppDbContext context,
            IAccountTransactionService transactionService,
            ILogger<PaymentService> logger)
        {
            _context = context;
            _transactionService = transactionService;
            _logger = logger;
        }

        public async Task<IEnumerable<Payment>> GetPaymentsAsync(string yearCode)
        {
            return await _context.payments
                .Where(p => !p.IsCancelled && p.YearCode == yearCode)
                .ToListAsync();
        }

        public async Task<IEnumerable<Payment>> GetPaymentsByYearAsync()
        {
            return await _context.payments
                .Where(p => p.PayDate.Year == DateTime.Now.Year)
                .ToListAsync();
        }

        public async Task<int> GetCurrentCodeAsync(string yearCode)
        {
            return await _context.payments
                .Where(p => p.YearCode == yearCode)
                .OrderByDescending(p => p.Id)
                .Select(p => (int?)p.paymentNo)
                .FirstOrDefaultAsync() ?? 0;
        }

        public async Task<Payment?> GetPaymentByIdAsync(int id)
        {
            return await _context.payments
                .Include(p => p.Details)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Payment>> GetPaymentsForPostingAsync(PostingFilterDTO filter)
        {
            return await _context.payments
                .Include(p => p.Details)
                .Where(p => p.PayDate >= filter.StartDate
                         && p.PayDate <= filter.EndDate
                         && !p.IsCancelled)
                .ToListAsync();
        }

        public async Task<Payment?> GetPaymentForPostingAsync(int id)
        {
            return await _context.payments
                .Include(p => p.Details)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            _context.payments.Add(payment);
            await _context.SaveChangesAsync();

            await _transactionService.CreatePaymentTransactionAsync(payment);
            return payment;
        }

        public async Task<Payment?> UpdatePaymentAsync(int id, Payment payment)
        {
            if (id != payment.Id)
                throw new ArgumentException("Payment ID mismatch");

            var existingPayment = await _context.payments
                .Include(p => p.Details)
                    .ThenInclude(d => d.InvoiceAllocations)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (existingPayment == null)
                return null;

            if (payment.AccountStatus == "Posted")
            {
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == payment.AccountTransactionId);

                if (accountTransaction != null)
                {
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }

            payment.AccountTransactionId = 0;
            payment.AccountStatus = "Draft";
            _context.Entry(existingPayment).CurrentValues.SetValues(payment);

            if (payment.Details != null)
            {
                foreach (var existingDetail in existingPayment.Details.ToList())
                {
                    if (!payment.Details.Any(d => d.Id == existingDetail.Id))
                    {
                        _context.PaymentAllocations.RemoveRange(existingDetail.InvoiceAllocations);
                        _context.paymentsDetail.Remove(existingDetail);
                    }
                }

                foreach (var detail in payment.Details)
                {
                    var existingDetail = existingPayment.Details
                        .FirstOrDefault(d => d.Id == detail.Id);

                    if (existingDetail != null)
                    {
                        _context.Entry(existingDetail).CurrentValues.SetValues(detail);

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var existingAllocation in existingDetail.InvoiceAllocations.ToList())
                            {
                                if (!detail.InvoiceAllocations.Any(a => a.Id == existingAllocation.Id))
                                {
                                    _context.PaymentAllocations.Remove(existingAllocation);
                                }
                            }

                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                var existingAllocation = existingDetail.InvoiceAllocations
                                    .FirstOrDefault(a => a.Id == allocation.Id);

                                if (existingAllocation != null)
                                {
                                    _context.Entry(existingAllocation)
                                        .CurrentValues
                                        .SetValues(allocation);
                                }
                                else
                                {
                                    allocation.Id = 0;
                                    allocation.PaymentDetailId = existingDetail.Id;
                                    existingDetail.InvoiceAllocations.Add(allocation);
                                }
                            }
                        }
                    }
                    else
                    {
                        detail.Id = 0;
                        detail.PaymentId = existingPayment.Id;

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                allocation.Id = 0;
                            }
                        }

                        existingPayment.Details.Add(detail);
                    }
                }
            }

            await _context.SaveChangesAsync();

            var paymentDet = await _context.payments
                .FirstOrDefaultAsync(p => p.Id == payment.Id);

            if (paymentDet != null)
                await _transactionService.CreatePaymentTransactionAsync(paymentDet);

            return existingPayment;
        }

        public async Task<bool> DeletePaymentAsync(int id)
        {
            var payment = await _context.payments.FindAsync(id);
            if (payment == null)
                return false;

            if (payment.AccountStatus == "verified")
                throw new InvalidOperationException(
                    $"Payment is verified to accounts with {payment.AccountTransactionId}. Payment cannot be cancelled.");

            var accountTransaction = await _context.AccountTransactions
                .FirstOrDefaultAsync(t => t.Id == payment.Id);

            if (accountTransaction != null)
            {
                _context.AccountTransactions.Remove(accountTransaction);
                _context.SaveChanges();
            }

            _context.payments.Remove(payment);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task PostPaymentToAccountsAsync(int paymentId)
        {
            var payment = await GetPaymentForPostingAsync(paymentId);

            if (payment == null)
                throw new KeyNotFoundException($"Payment with Id {paymentId} not found.");

            if (payment.AccountStatus == "Posted")
                throw new InvalidOperationException("Payment is already posted to accounting.");

            await _transactionService.CreatePaymentTransactionAsync(payment);
        }
    }
}
