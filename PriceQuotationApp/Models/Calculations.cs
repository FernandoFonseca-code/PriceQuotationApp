namespace PriceQuotationApp.Models;
    public class Calculations
    {
    /// <summary>
    /// 
    /// </summary>
        public decimal? Subtotal { get; set; }    
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount => (Subtotal ?? 0) * ((DiscountPercent ?? 0) / 100);
        public decimal Total => (Subtotal ?? 0) - DiscountAmount;
    }
