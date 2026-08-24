using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class TripProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Qty { get; set; }

        [Required]
        public int UnitId { get; set; }

        // Foreign Key (automatically set when added via parent navigation)
        [Required]
        [JsonIgnore]
        public int TripTransactionId { get; set; }

        // Navigation property to AccountMaster
        [ForeignKey(nameof(ProductId))]
        [JsonIgnore]
        public virtual Product? ProductMaster { get; set; }

    }
}
