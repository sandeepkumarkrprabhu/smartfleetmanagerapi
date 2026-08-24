using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class AccountPostingSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string DocumentType { get; set; }

        [MaxLength(50)]
        public string DocumentSubType { get; set; }
        
        public int DebitAccountId { get; set; } = 0;
        
        public int CreditAccountID { get; set; } = 0;

        public bool IsTripExpensePaidAlready {get;set; }

    }
}
