
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class AccountMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int AccountID { get; set; }

        public int ParentAccountID { get; set; }
        [Required]
        [MaxLength(50)]
        public string AccountCode { get; set; } = string.Empty;

        public string AccountGroupCode {get; set; }

        [Required]
        [MaxLength(100)]
        public string AccountName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Address {get;set;}

        public string Notes { get; set; } = string.Empty;

        public string AccountType {get;set; }=string.Empty;
        public string GroupName { get; set; }

        public bool IsActive { get; set; }

        public int BranchID { get; set; }

        public string? AccountMode {get;set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }

        //Bank Information 
        public string  BankName { get; set; } = string.Empty;
        public string BranchName {get;set; } = string.Empty;
        public string AccountNumber {get;set; } = string.Empty;
        public string IFSCCode { get; set; } = string.Empty;
        public string SWIFTCode { get; set; } = string.Empty;   
        public bool IsBankAccount { get; set; } = false;
        public bool IsCashAccount { get; set; } = false;


        //Relations
        [JsonIgnore]        
        public ICollection<Employee>? Employees { get; set; }

    }
}
