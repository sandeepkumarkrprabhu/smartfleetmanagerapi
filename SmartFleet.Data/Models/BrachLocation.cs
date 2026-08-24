
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class BrachLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(25)]
        public string ContactNo { get; set; }

        [MaxLength(25)]
        public string ContactPhone { get; set; }

        public string CompanyId { get; set; }

        [MaxLength(100)]
        public string? EmailId {get;set; }   

        [MaxLength(25)]
        public string? PANNo { get; set; }

        [MaxLength(25)]
        public string? GSTNo { get; set; }

        [MaxLength(25)]
        public string? SACNo { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }
    }
}
