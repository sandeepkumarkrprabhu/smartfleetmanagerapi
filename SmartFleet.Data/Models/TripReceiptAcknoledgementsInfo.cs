
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class TripReceiptAcknoledgementsInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TripId { get; set; }   // FK to LorryReceipt

        [Required]
        public DateTime DeliveredOn { get; set; }

        [Required]
        [MaxLength(150)]
        public string ReceivedByName { get; set; }

        [MaxLength(20)]
        public string? ReceiverMobile { get; set; }

        [MaxLength(500)]
        public string? Remarks { get; set; }

        [MaxLength(500)]
        public string? UploadedReceiptUrl { get; set; }  // POD / signed LR upload

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(TripId))]
        [JsonIgnore]
        public virtual TripTransaction? TripDetailMaster { get; set; }
    }
}
