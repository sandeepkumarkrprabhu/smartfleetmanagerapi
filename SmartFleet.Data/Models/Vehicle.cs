using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string VehicleCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int AccountId { get; set; }

        [MaxLength(50)]
        public string VehicleType { get; set; }

        public int tons { get; set; }

        [MaxLength(50)]
        public string status { get; set; }

        [MaxLength(50)]
        public string? Make { get; set; }

        [MaxLength(50)]
        public string? Model { get; set; }

        [MaxLength(50)]
        public string? Color { get; set; }

        [MaxLength(50)]
        public string? year { get; set; }

        public bool IsActive { get; set; }

        public bool IsOwn { get; set; }

        public int BranchID { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Weight { get; set; }

    }
}
