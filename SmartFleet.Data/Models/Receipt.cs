using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class Receipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime ReceiptDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReceiptMode { get; set; } = string.Empty;

        [Required]
        public int? ToAccountId { get; set; }

        [MaxLength(100)]
        public string ReferenceNo { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(250)]
        public string? Notes { get; set; }

        public int? JournalEntryId { get; set; }

        public DateTime ReceiptCreateDate { get; set; } = DateTime.Now;

        public DateTime ReceiptUpdateDate { get; set; } = DateTime.Now;
        public bool IsCancelled { get; set; } = false;

        public int receiptNo { get; set; }

        public string? YearCode { get; set; }

        public string? CreatedUser { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        public int? AccountTransactionId { get; set; }
        public string? AccountStatus { get; set; } = "Draft";

        // =========================
        // Navigation Properties
        // =========================

        public virtual List<ReceiptDetail> Details { get; set; } = new();

        [ForeignKey(nameof(ToAccountId))]
        [JsonIgnore]
        public virtual AccountMaster? ToAccount { get; set; }

        

        [JsonIgnore]
        public virtual JournalEntry? JournalEntry { get; set; }
    }
}
