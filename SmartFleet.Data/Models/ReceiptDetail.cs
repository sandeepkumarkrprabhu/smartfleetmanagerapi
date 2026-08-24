using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class ReceiptDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign Key to Receipt
        [Required]
        public int ReceiptId { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public string? Description { get; set; }

        // =====================
        // Navigation
        // =====================

        [JsonIgnore]
        [ForeignKey(nameof(ReceiptId))]
        public virtual Receipt? Receipt { get; set; }

        public virtual List<ReceiptAllocation>? InvoiceAllocations { get; set; } = new();
    }

}
