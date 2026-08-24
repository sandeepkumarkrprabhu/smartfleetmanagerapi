using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class VehicleVendorRents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public int VendorId { get; set; }

        public DateTime RentFromDate {get;set; }
        public DateTime RentToDate {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal RentAmount { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        // Navigation property to Vehicle Master
        [ForeignKey(nameof(VehicleId))]
        [JsonIgnore]
        public virtual Vehicle? VehicleMaster { get; set; }

        [ForeignKey(nameof(VendorId))]
        [JsonIgnore]
        public virtual Vendor? VendorMaster { get; set; }
    }
}
