using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class TripConsigneeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? LRNo {get;set; }
        
        [MaxLength(200)]
        public string? InvoiceNo {get;set; }

        [Required]
        public int ToConsigneeId { get; set; }

        [Required]
        public int DestinationId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Qty { get; set; }

        [Required]
        public int UnitId { get; set; }

        //Valuation of Goods
        [Column(TypeName = "decimal(18,2)")]
        public decimal? GoodsValue {get;set; }

        // Foreign Key (automatically set when added via parent navigation)
        [Required]
        [JsonIgnore]
        public int TripTransactionId { get; set; }

        // Navigation property to AccountMaster
        [ForeignKey(nameof(ToConsigneeId))]
        [JsonIgnore]
        public Customer? ToConsignee { get; set; }

        [ForeignKey(nameof(DestinationId))]
        [JsonIgnore]
        public Location? Destination { get; set; }

        public DateTime InvoiceDate { get; set; }

        //Freight Charges
        [Column(TypeName = "decimal(18,2)")]
        public decimal FreightCharges { get; set; }
    }
}
