using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class FuelLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FuelLogId { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Vehicle { get; set; }
        public int? DriverId { get; set; }
        public string? Driver { get; set; }

        public int? tripId {get;set; }

        [MaxLength(50)]
        public string FuelType { get; set; }

        [MaxLength(100)]
        public string Station { get; set; }
        public DateTime LogDate { get; set; } = DateTime.UtcNow;

        public long? Odometer { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Volume { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }
        public bool IsFullTank { get; set; }

        [MaxLength(50)]
        public string InvoiceNo { get; set; }

        [MaxLength(150)]
        public string Notes { get; set; }
        public string PaymentMode {get;set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(tripId))]
        public virtual TripTransaction? Trip { get; set; }
    }
}
