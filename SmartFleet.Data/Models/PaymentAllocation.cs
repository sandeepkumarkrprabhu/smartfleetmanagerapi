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
    public class PaymentAllocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PaymentDetailId { get; set; }

        public int InvoiceNo { get; set; }
        public int vendorId { get; set; }
        public DateTime BillDate { get; set; }

        public string Name { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal OutstandingAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        // NAVIGATION
        [JsonIgnore]
        [ForeignKey(nameof(PaymentDetailId))]
        public virtual PaymentDetail? PaymentDetail { get; set; }
    }
}
