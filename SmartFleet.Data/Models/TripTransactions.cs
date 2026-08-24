using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SmartFleet.Data.Models
{
    public class TripTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Code { get; set; }

        [Required]
        public DateTime LRDate {get;set; }

        [MaxLength(50)]
        public string? ReferenceNo {get;set; }

        [Required]
        public int FromCustomerId { get; set; }

        [Required]
        public int ToCustomerId { get; set; }

        [Required]
        public int OriginId { get; set; }

        [Required]
        public int DestinationId { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        // Driver/Employee reference
        public int EmployeeId { get; set; }

        public string? Route { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime ExpectedDeliveryDate { get; set; }

        public DateTime? ActualDeliveryDate { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        [MaxLength(300)]
        public string? Notes { get; set; }

        public int ProductCount { get; set; }

        public int StockistID {get; set; }

        // Navigation property to child records
        //public virtual List<TripProductDetail>? ProductDetails { get; set; } = new();
        public virtual List<TripConsigneeDetails> ConsigneeDetails { get; set; } = new();

        public string? Createduser { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;

        public string YearCode { get; set; } = DateTime.Now.Year.ToString();

        [Column(TypeName = "decimal(18,2)")]
        public decimal DriverBata { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TollCharges { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FuelCharges { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal InsuranceAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PackagingCharges { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadingCost { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CommissionAmt { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AdditionalCost { get; set; }

        public int? BillNo {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public int? MtnNo {get;set; }

        public int? Kms { get;set; }
        public string? InvoiceNo { get;set;}
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FrieghtCharges {get;set; }

        //Valuation of Goods
        [Column(TypeName = "decimal(18,2)")]
        public decimal? GoodsValue {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? LRCharges {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? HaltingCharges {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? HandlingCharges {get;set; }

        public int? VendorId { get; set; }

        public bool IsSalesReturnTrip {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? VendorRentCharges {get;set; }

        public bool IsReceiptReceived {get;set; } = false;

        public int? TaxId { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TaxPercentage {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? IGSTAmount {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? CGSTAmount {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? SGSTAmount {get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? finalAmount {get;set; }

        public string TransactionStatus {get;set; } ="Draft";
        public int TransactionReferenceId    {get;set; } =0;

        // Navigation Properties
        [ForeignKey(nameof(FromCustomerId))]
        [JsonIgnore]
        public Customer? FromCustomer { get; set; }

        [ForeignKey(nameof(ToCustomerId))]
        [JsonIgnore]
        public Customer? ToCustomer { get; set; }

        [ForeignKey(nameof(OriginId))]
        [JsonIgnore]
        public Location? Origin { get; set; }

        [ForeignKey(nameof(DestinationId))]
        [JsonIgnore]
        public Location? Destination { get; set; }

        [ForeignKey(nameof(VehicleId))]
        [JsonIgnore]
        public Vehicle? Vehicle { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [JsonIgnore]
        public Employee? Driver { get; set; }

        [ForeignKey(nameof(VendorId))]
        [JsonIgnore]
        public Vendor? VendorMaster { get; set; }

        [ForeignKey(nameof(StockistID))]
        [JsonIgnore]
        public Customer? FromStockist { get; set; }

    }
}
