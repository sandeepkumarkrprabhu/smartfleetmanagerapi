
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class JournalEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalEntryId { get; set; }

        [MaxLength(50)]
        public string? ReferenceNumber { get; set; } // e.g., "EXP-2025-001"

        [Required]
        public int JournalNo { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.UtcNow;

        [MaxLength(250)]
        public string? Narration { get; set; }  // e.g., "Fuel expense paid in cash"


        public string? YearCode { get; set; }

        public string? CreatedUser { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; } = DateTime.Now;

        public string? JournalType {get;set;}
        // Navigation
        public List<JournalEntryLine> Lines { get; set; } = new();

        // Computed properties for validations
        [NotMapped]
        public decimal TotalDebit => Lines?.Where(l => l.Debit > 0).Sum(l => l.Debit) ?? 0;

        [NotMapped]
        public decimal TotalCredit => Lines?.Where(l => l.Credit > 0).Sum(l => l.Credit) ?? 0;

        public int? AccountTransactionId { get; set; }
        public string? AccountStatus { get; set; } = "Draft";
    }
}
