using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFleet.Data.Models
{
    public class ApplicationModuleSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string ModuleName { get; set; }     // Accounts, Inventory, Admin
        
        [Required, MaxLength(150)]
        public string SettingName { get; set; }    // AllowBackDateEntry

        [Required, MaxLength(200)]
        public string SettingKey { get; set; }     // UNIQUE key (Accounts.AllowBackDateEntry)

        public string DataType { get; set; }       // bool, int, string, decimal

        public string DefaultValue { get; set; }

        public bool IsEditable { get; set; } = true;
        public bool IsActive { get; set; } = true;

        public string Description { get; set; }
    }
}
