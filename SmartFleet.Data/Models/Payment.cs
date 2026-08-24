using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime PayDate { get; set; }

        [Required, MaxLength(50)]
        public string PayMode { get; set; } = string.Empty;  // e.g., Cash, Bank Transfer, Cheque

        [Required]
        public int FromAccountId { get; set; }  // Credit (Cash/Bank Account)

        [Required]
        public int PayeeAccountId { get; set; } // Vendor or Payee Account

        [MaxLength(100)]
        public string ReferenceNo { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(250)]
        public string? Notes { get; set; }

        public int? VehicleId { get; set; }   // Optional
        public int? TripId { get; set; }      // Optional

        public DateTime PaymentCreateDate { get; set; } = DateTime.Now;

        public DateTime PaymentUpdateDate { get; set; } = DateTime.Now;
        public bool IsCancelled { get; set; } = false;

        public int paymentNo { get; set; }

        public string? YearCode { get; set; }

        public string? CreatedUser { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        public int? AccountTransactionId { get; set; }
        public string? AccountStatus { get; set; } = "Draft";


        // Only include this in API; it's part of the Payment itself
        public virtual List<PaymentDetail> Details { get; set; } = new List<PaymentDetail>();

        // ====== Navigation Properties (Hidden in Swagger) ======

        [ForeignKey(nameof(FromAccountId))]
        [JsonIgnore] // hides from Swagger & JSON response
        public virtual AccountMaster? FromAccount { get; set; }

        [ForeignKey(nameof(VehicleId))]
        [JsonIgnore]
        public virtual Vehicle? Vehicle { get; set; }

        [ForeignKey(nameof(TripId))]
        [JsonIgnore]
        public virtual TripTransaction? Trip { get; set; }

        [JsonIgnore]
        public int? JournalEntryId { get; set; }

        [JsonIgnore]
        public virtual JournalEntry? JournalEntry { get; set; }
    }
}
