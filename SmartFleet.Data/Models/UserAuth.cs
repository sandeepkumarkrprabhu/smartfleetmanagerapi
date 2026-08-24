
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class UserAuth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }

        [MaxLength(50)]
        public string UserCode { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;

        public int RoleId {get;set; }

        // Navigation property to AccountMaster
        [ForeignKey(nameof(RoleId))]
        public virtual UserRole? UserRole { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }

    }
}
