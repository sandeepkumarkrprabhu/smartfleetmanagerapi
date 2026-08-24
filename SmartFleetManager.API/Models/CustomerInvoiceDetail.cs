namespace SmartFleetManager.API.Models
{
    public class CustomerInvoiceDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public string UntiCode { get; set; }
        public string UnitName  {get;set; }

        public int TripId { get; set; }
        public string TripCode {get;set; }
        public string LRNo {get;set; }
        public DateTime LRDate {get;set; }
        public string Description {get;set; }
        public bool IsSalesReturn {get;set; }

        // Origin Customer
        public string FromCustomerName {get;set; }

        // Billing Stockist 
        public string FromStockistName {get;set; }

        // Destination Customer
        public string ToCustomerName {get;set; }

        public string Origin {get; set; }
        public string Destination { get; set; }
        public string Route { get; set; }
        public int KMS {get; set; }
        public string InvoiceNo {get; set; }
        public string RMTInvoiceNo {get; set; }
        public decimal GoodsValue {get; set; }
        public int VehicleId { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleType { get; set; }
        public int DriverId { get; set; }
        public decimal Freight {get; set; }
        public decimal haltingCharges {get; set; }
        public decimal handlingCharges {get; set; }
        public decimal LoadingCharges {get;set; }
        public decimal LrCharges {get; set; }
        public decimal EstiamteCost {get;set; }
        public string remarks {get; set; }



    }
}
