namespace SmartFleetManager.API.Interfaces
{
    public interface IInvoiceService
    {
        Task PostInvoiceToAccountsAsync(int invoiceId);
        Task UnpostInvoiceAsync(int invoiceId);
    }
}
