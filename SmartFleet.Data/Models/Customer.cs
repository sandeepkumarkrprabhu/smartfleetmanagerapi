using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string CustomerCode {get;set;}   
        
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

        [MaxLength(200)]
        public string State {get;set;}

        [MaxLength(50)]
        public string TaxNumber {get;set;}
        
        [MaxLength(150)]
        public string PaymentTerms {get;set;}
        
        [MaxLength(20)]
        public string CustomerType {get;set;}
        
        [MaxLength(50)]
        public string BillingMode {get;set;}
        
        [MaxLength(80)]
        public string GSTNo {get;set;}
        
        [MaxLength(50)]
        public string PanNo {get;set;}

        public bool IsActive { get; set; }

        public int BranchID { get; set; }

        public int? AccountId { get; set; }

        public bool IsTaxableInvoice { get; set; }


        // Navigation property to AccountMaster
        
        [ForeignKey(nameof(AccountId))]
        public virtual AccountMaster? AccountMaster { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }

        public string? InvoiceTemplateName {get;set;}

    }
}
