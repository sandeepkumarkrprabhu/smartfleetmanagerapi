
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Code { get; set; }

        public int RMTInvoiceNo { get; set; }

        [Required]
        public DateTime BillDate {get;set; }

        [Required]
        public int CustomerId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalTaxAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GrandAmount { get; set; }

        [Required, MaxLength(50)]
        public string status { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int BranchId { get; set; }
        public string YearCode { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxPer  {get;set; }

        public int? AccountTransactionId { get; set; }
        public string AccountStatus { get; set; } = "Draft";

        public string? CreatedUser { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal IGST {get; set; } = 0;
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal CGST {get; set; }= 0;
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal SGST {get; set; }= 0;

        public DateTime? BIllFromDate { get; set; }
        public DateTime? BillToDate { get; set; }

        public ICollection<BillItemDetails> ProductDetails { get; set; }

        // ✅ Navigation Properties
        [ForeignKey(nameof(CustomerId))]
        [JsonIgnore]
        public Customer? Customer { get; set; }

    }
}
