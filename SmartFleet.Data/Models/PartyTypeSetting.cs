using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartFleet.Data.Models
{
    public class PartyTypeSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public string AccountMode { get; set; } = "";

        public bool IsExpenseAccountRequired { get; set; }
        public bool IsPayableAccountRequired { get; set; }
        public bool IsAdvanceAccountRequired { get; set; }
        public bool IsReceivableAccountRequired { get; set; }


    }
}
