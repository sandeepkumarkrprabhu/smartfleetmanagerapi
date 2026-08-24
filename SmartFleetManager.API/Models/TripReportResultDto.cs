namespace SmartFleetManager.API.Models
{
    public class TripReportResultDto
{
    public string LRNo { get; set; }
    public DateTime LRDate { get; set; }
    public string RmtInvoiceNo { get; set; }

    public string VehicleNo { get; set; }
    public string VehicleType { get; set; }

    public string Vendor { get; set; }
    public decimal VendorRentCharges { get; set; }

    public string status {get;set; }

    public string FromLocation { get; set; }
    public string ToLocation { get; set; }

    public string StockistName { get; set; }
    public string CustomerName { get; set; }
    public string DriverName { get; set; }

    public int? MTN { get; set; }
    public int? KMS { get; set; }

    public decimal Commission { get; set; }
    public decimal FreightCharges { get; set; }
    public decimal GoodsValue { get; set; }
    public decimal LRCharges { get; set; }
    public decimal HaltingCharges { get; set; }
    public decimal HandlingCharges { get; set; }
    public decimal DriverCharges { get; set; }
    public decimal FuelCharges { get; set; }
    public decimal TollCharges { get; set; }
    public decimal TotalCost { get; set; }

    public string Notes { get; set; }

    public string ConsigneeName { get; set; }
}

}
