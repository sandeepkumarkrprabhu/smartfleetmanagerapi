using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFleet.Data.Models
{
    public class AccountTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required, MaxLength(50)]
        public string DocumentType { get; set; }

        [Required, MaxLength(50)]
        public string ReferenceNo { get; set; }

        public int AccountID { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        public string CurrencyCode { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ExchangeRate { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; }

        [Required, MaxLength(50)]
        public string AccountingStatus { get; set; }

        [MaxLength(20)]
        public string YearCode { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public int? branchId { get; set; }

        public int? DocumentRefId { get; set; }

        // Navigation Property (One-to-Many)
        public List<AccountTransactionDetail> AccountTransactionDetails { get; set; } = new();

        
    }
}
