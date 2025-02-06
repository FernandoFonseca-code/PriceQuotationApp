namespace PriceQuotationApp.Models;
    public class Calculations
    {
        public decimal Subtotal { get; set; }
        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);
        public decimal Total => Subtotal - DiscountAmount;
    }
