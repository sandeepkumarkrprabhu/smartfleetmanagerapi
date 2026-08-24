using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFleet.Data.Models
{
    public class UserPreferences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [MaxLength(50)]
        public string KeyName {get; set;}

        [MaxLength(50)]
        public string KeyValue { get; set; }
    }
}
