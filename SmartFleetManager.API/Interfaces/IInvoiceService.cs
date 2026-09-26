using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<CustomerInvoice>> GetCustomerBillsAsync(string yearCode);
        Task<IEnumerable<MonthlyInvoiceSummaryPrint>> GetCustomerInvoiceSummaryPrintAsync(int id);
        Task<object?> GetOutstandingInvoicesAsync(int id);
        Task<object?> GetVendorOutstandingInvoiceAsync(int id);
        Task<CustomerInvoice?> GetCustomerInvoiceAsync(int id);
        Task<IEnumerable<CustomerInvoiceGSTSummaryResult>> GetInvoiceGSTReportAsync(InvoiceReportFilterDto filter);
        Task<IEnumerable<CustomerInvoiceSummary>> GetCustomerInvoiceSummaryReportAsync(InvoiceReportFilterDto filter);
        Task<IEnumerable<CustomerInvoice>> GetInvoiceReportAsync(InvoiceReportFilterDto filter);
        Task<string?> GetCurrentCodeAsync();
        Task<Bill?> GetInvoiceDetailAsync(int invoiceNo);
        Task<int> GetCurrentRMTInvoiceNoAsync(string yearCode);
        Task<Bill?> GetCustomerInvoiceByIdAsync(int id);
        Task<List<Bill>> GetCustomerInvoicePendingAsync();
        Task<IReadOnlyList<Bill>> GetInvoicesForPostingAsync(PostingFilterDTO filter);
        Task<Bill?> GetInvoiceForPostingAsync(int id);
        Task<Bill> CreateInvoiceAsync(Bill bill);
        Task<Bill?> UpdateInvoiceAsync(int id, Bill bill);
        Task<bool> DeleteInvoiceAsync(int id);
        Task PostInvoiceToAccountsAsync(int invoiceId);
        Task UnpostInvoiceAsync(int invoiceId);
    }
}