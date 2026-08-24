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
    public class AccountTransactionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int AccountID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Debit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Credit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BaseDebit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BaseCredit { get; set; }

        public int InvoiceTransactionID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AllocationAmount { get; set; }

        [MaxLength(150)]
        public string Narration { get; set; }

        public int? CostCenterID { get; set; }

        public int? branchID { get; set; }

        [ForeignKey("AccountTransaction")]
        public int TransactionId { get; set; }

        [JsonIgnore]
        public AccountTransaction AccountTransaction { get; set; }
    }
}
