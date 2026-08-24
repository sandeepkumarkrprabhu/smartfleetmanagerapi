using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFleet.Data.Models
{
    public class SmartLorryReceipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ECNo { get; set; }

        public DateTime ReceiptDate { get; set; }
        public int VehicleId { get; set; }
        public int FromLocationId { get; set; }
        public int ToLocationId { get; set; }

        [MaxLength(200)]
        public string? InvoiceNo {get;set; }

        public int FromCsutomerId { get; set; }
        public int ConsigneeId { get; set; }

        public int Packages {get;set; }
        public int ProductId { get; set; }  

        public int UnitId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? GoodsValue {get;set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? Weight {get;set; }

        public string InsuranceCo {get;set; }

        public string PolicyNo {get;set; }
        public DateTime? InsuredDate {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? InsuredAmount {get;set; } 

        public string InsuredRisk {get;set; }

    }
}
