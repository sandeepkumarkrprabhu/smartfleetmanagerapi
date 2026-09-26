using Microsoft.AspNetCore.Mvc;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly ILogger<BillController> _logger;

        public BillController(ILogger<BillController> logger, IInvoiceService invoiceService)
        {
            _logger = logger;
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetCustomerBills(string yearCode)
        {
            try { return Ok(await _invoiceService.GetCustomerBillsAsync(yearCode)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving customer invoices"); }
        }

        [HttpGet("GetCustomerInvoiceSummaryPrint/{id}")]
        public async Task<ActionResult<IEnumerable<MonthlyInvoiceSummaryPrint>>> GetCustomerInvoiceSummaryPrint(int id)
        {
            try { return Ok(await _invoiceService.GetCustomerInvoiceSummaryPrintAsync(id)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving customer invoice summary"); }
        }

        [HttpGet("GetOutstandingInvoices/{id}")]
        public async Task<IActionResult> GetOutstandingInvoices(int id)
        {
            try { return Ok(await _invoiceService.GetOutstandingInvoicesAsync(id)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving customer outstanding invoices"); }
        }

        [HttpGet("GetVendorOutstandingInvoice/{id}")]
        public async Task<IActionResult> GetVendorOutstandingInvoice(int id)
        {
            try { return Ok(await _invoiceService.GetVendorOutstandingInvoiceAsync(id)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving vendor outstanding invoices"); }
        }

        [HttpGet("GetCustomerInvoice/{id}")]
        public async Task<ActionResult<IEnumerable<CustomerInvoice>>> GetCustomerInvoice(int id)
        {
            try
            {
                var invoice = await _invoiceService.GetCustomerInvoiceAsync(id);
                return invoice == null ? NotFound("Invoice not found.") : Ok(invoice);
            }
            catch (Exception ex) { return LogAnd500(ex, "retrieving invoice data"); }
        }

        [HttpGet("GetInvoiceGSTReport")]
        public async Task<IActionResult> GetInvoiceGSTReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try { return Ok(await _invoiceService.GetInvoiceGSTReportAsync(filter)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving invoice GST report"); }
        }

        [HttpGet("GetCustomerInvoiceSummaryReport")]
        public async Task<IActionResult> GetCustomerInvoiceSummaryReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try { return Ok(await _invoiceService.GetCustomerInvoiceSummaryReportAsync(filter)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving invoice summary report"); }
        }

        [HttpGet("GetInvoiceReport")]
        public async Task<IActionResult> GetInvoiceReport([FromQuery] InvoiceReportFilterDto filter)
        {
            try { return Ok(await _invoiceService.GetInvoiceReportAsync(filter)); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving invoice report"); }
        }

        [HttpGet("CurrentCode")]
        public async Task<IActionResult> GetCurrentCode()
        {
            try { return Ok(new { CurrentCode = await _invoiceService.GetCurrentCodeAsync() }); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving current invoice code"); }
        }

        [HttpGet("GetInvoiceDetail/{invoiceNo}")]
        public async Task<IActionResult> GetInvoiceDetails(int invoiceNo)
        {
            try { return Ok(new { invoiceDetail = await _invoiceService.GetInvoiceDetailAsync(invoiceNo) }); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving invoice detail"); }
        }

        [HttpGet("CurrentRMTInvoiceNo/{yearCode}")]
        public async Task<IActionResult> GetCurrentRMTInvoiceNo(string yearCode)
        {
            try { return Ok(new { CurrentCode = await _invoiceService.GetCurrentRMTInvoiceNoAsync(yearCode) }); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving current RMT invoice number"); }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bill>> GetCustomerInvoiceById(int id)
        {
            try
            {
                var bill = await _invoiceService.GetCustomerInvoiceByIdAsync(id);
                return bill == null ? NotFound() : Ok(bill);
            }
            catch (Exception ex) { return LogAnd500(ex, "retrieving customer invoice"); }
        }

        [HttpGet("GetCustomerInvoicePending")]
        public async Task<ActionResult<List<Bill>>> GetCustomerInvoicePending()
        {
            try { return Ok(await _invoiceService.GetCustomerInvoicePendingAsync()); }
            catch (Exception ex) { return LogAnd500(ex, "retrieving pending invoices"); }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            try
            {
                var invoices = await _invoiceService.GetInvoicesForPostingAsync(filter);
                if (!invoices.Any()) return NotFound("No invoices found for the selected date range.");
                foreach (var invoice in invoices) await _invoiceService.PostInvoiceToAccountsAsync(invoice.Id);
                return Ok(new { Message = "Invoice posting completed", Count = invoices.Count });
            }
            catch (Exception ex) { return LogAnd500(ex, "posting invoices to accounts"); }
        }

        [HttpPost("AccountPosting/{billId}")]
        public async Task<IActionResult> PostBillToAccounting(int billId)
        {
            try
            {
                var bill = await _invoiceService.GetInvoiceForPostingAsync(billId);
                if (bill == null) return NotFound($"Bill with Id {billId} not found.");
                if (bill.AccountStatus == "Posted") return BadRequest("Bill is already posted to accounting.");
                await _invoiceService.PostInvoiceToAccountsAsync(bill.Id);
                return Ok(new { BillId = billId });
            }
            catch (Exception ex) { return LogAnd500(ex, "posting invoice to accounting"); }
        }

        [HttpPost]
        public async Task<ActionResult<Bill>> PostInvoices(Bill bill)
        {
            try
            {
                var created = await _invoiceService.CreateInvoiceAsync(bill);
                return CreatedAtAction(nameof(GetCustomerInvoiceById), new { id = created.Id }, created);
            }
            catch (InvalidOperationException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return LogAnd500(ex, "posting invoice"); }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(int id, Bill bill)
        {
            try
            {
                var updated = await _invoiceService.UpdateInvoiceAsync(id, bill);
                if (updated == null) return NotFound();
                return Ok(updated);
            }
            catch (ArgumentException ex) { return BadRequest(ex.Message); }
            catch (InvalidOperationException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return LogAnd500(ex, "updating customer invoice"); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            try
            {
                var deleted = await _invoiceService.DeleteInvoiceAsync(id);
                return deleted ? NoContent() : NotFound();
            }
            catch (InvalidOperationException ex) { return BadRequest(new { error = ex.Message }); }
            catch (Exception ex) { return LogAnd500(ex, "deleting customer invoice"); }
        }

        private ObjectResult LogAnd500(Exception ex, string operation)
        {
            _logger.LogError(ex, "Error occurred while {Operation}.", operation);
            return StatusCode(500, $"An error occurred while {operation}.");
        }
    }
}