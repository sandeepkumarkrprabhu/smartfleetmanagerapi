
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class PaymentDetail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Foreign Key to Receipt
    [Required]
    public int PaymentId { get; set; }

    [Required]
    public int AccountId { get; set; }  // Debit account (e.g., Expense or Vendor)

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [MaxLength(250)]
    public string? Description { get; set; }

    // Navigation Properties
    [JsonIgnore]
    [ForeignKey(nameof(PaymentId))]
    public virtual Payment? Payment { get; set; }

    public virtual List<PaymentAllocation>? InvoiceAllocations { get; set; }= new();

}
}
