
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string VendorCode {get;set;}   
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string ContactPerson {get;set;}  
        
        [MaxLength(100)]
        public string Email {get;set;}
        
        [MaxLength(30)]
        public string Phone {get;set;}
        
        [MaxLength(200)]
        public string Address {get;set;}

        [MaxLength(50)]
        public string TaxNumber {get;set;}
        
        [MaxLength(150)]
        public string PaymentTerms {get;set;}
        
        [MaxLength(20)]
        public string CustomerType {get;set;}
        
        [MaxLength(50)]
        public string BillingMode {get;set;}
        public bool IsActive { get; set; }

        public int BranchID { get; set; }

        [MaxLength(100)]
        public string Agentname {get; set;}

        [Column(TypeName = "decimal(18,2)")]
        public decimal commissionPer {get;set;} = 0;


        // Navigation property to AccountMaster
        public int? AccountId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }

        // ✅ Navigation Properties
        [ForeignKey(nameof(AccountId))]
        [JsonIgnore]
        public AccountMaster? AccountMaster { get; set; }
    }
}
