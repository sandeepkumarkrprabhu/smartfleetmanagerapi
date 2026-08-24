using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class UserRoleMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int MenuId { get; set; }

        [Required]
        public int RoleId { get; set; }

        public bool IsActive {get;set; }

        public bool? HasAddPermission { get; set; } =false;
        public bool? HasEditPermission { get; set; } =false;
        public bool? HasDeletePermission { get; set; } =false;
        public bool? HasPrintPermission { get; set; } =false;
        public bool? HasPostingPermission { get; set; } =false;

        public int OrderId {get;set; }

        // Navigation property to Menu
        [ForeignKey(nameof(MenuId))]
        public virtual MenuMaster? MenuMaster { get; set; }

        // Navigation property to user Role
        [ForeignKey(nameof(RoleId))]
        public virtual UserRole? UserRole { get; set; }

    }
}
