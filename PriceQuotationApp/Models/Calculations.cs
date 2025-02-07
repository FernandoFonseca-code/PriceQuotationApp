using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models;
/// <summary>
/// The Calculations class is used to perform the calculations for the price quotation app.
/// Its most ideal to place it in the Models folder since it is a model.
/// </summary>
public class Calculations
{
    /// <summary>
    /// Add the ? to the decimal type to make it nullable since the 
    /// assignment requires it to be blank at the start.
    /// Also add the required and range validation attributes.
    /// </summary>
    [Required(ErrorMessage = "Subtotal is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Subtotal must be greater than 0")]
    public decimal? Subtotal { get; set; }

    /// <summary>
    /// The user entered discount percent with validation attributes
    /// required and range
    /// </summary>
    [Required(ErrorMessage = "Discount percent is required")]
    [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100")]
    public decimal? DiscountPercent { get; set; }

    public decimal DiscountAmount => (Subtotal ?? 0) * ((DiscountPercent ?? 0) / 100);
    public decimal Total => (Subtotal ?? 0) - DiscountAmount;
}
