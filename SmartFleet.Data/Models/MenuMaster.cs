using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public  class MenuMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int MenuID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name {get;set;}

        public int ModuleID { get; set; }

        public int? GroupId {get;set; }

        [Required]
        [MaxLength(50)]
        public string url {get;set;}

        public int orderNo {get; set;}

        public bool isActive {get;set; }

        public string IconName {get;set; }
    }
}
