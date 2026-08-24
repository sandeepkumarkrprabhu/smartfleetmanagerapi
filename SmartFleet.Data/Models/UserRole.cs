using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int RoleID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name {get;set;}

        public bool isActive {get;set; }

        public DateTime CreatedAt {get;set; }
        public DateTime UpdatedAt {get;set; }

    }
}
