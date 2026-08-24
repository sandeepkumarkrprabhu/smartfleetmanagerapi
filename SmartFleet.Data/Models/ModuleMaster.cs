using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class ModuleMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModuleID { get; set; }

        public string ModuleName {get;set; }
        public string ModuleVersion {get;set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
