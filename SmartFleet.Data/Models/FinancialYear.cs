
using System.ComponentModel.DataAnnotations;

namespace SmartFleet.Data.Models
{
    public class FinancialYear
    {
        [Key]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(100)]
        public string Description { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime FinStartDate { get; set; }
        public DateTime FinEndDate { get; set; }

        public bool? IsYearClosed { get; set; }

    }
}
