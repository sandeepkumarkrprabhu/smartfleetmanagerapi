
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class JournalEntryLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JournalEntryLineId { get; set; }

        public int JournalEntryId { get; set; }
        [Required]
        public int AccountId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Debit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Credit { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        // Navigation
        [JsonIgnore]
        [ForeignKey(nameof(JournalEntryId))]
        public JournalEntry? JournalEntry { get; set; }


        [JsonIgnore]
        [ForeignKey(nameof(AccountId))]
        public AccountMaster? Account { get; set; }
    }
}
