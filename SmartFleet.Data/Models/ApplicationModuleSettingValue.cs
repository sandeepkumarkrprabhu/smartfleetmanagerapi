using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartFleet.Data.Models
{
    public class ApplicationModuleSettingValue
    {
        public int Id { get; set; }

        public int SettingId { get; set; }

        [ForeignKey(nameof(SettingId))]
        [JsonIgnore]
        public ApplicationModuleSetting Setting { get; set; }

        [Required, MaxLength(150)]
        public string Value { get; set; }

        public int? CompanyId { get; set; }   // optional (multi-company support)
        public int? BranchId { get; set; }    // optional
    }
}
