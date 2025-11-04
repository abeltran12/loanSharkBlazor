using System.ComponentModel.DataAnnotations;

namespace MortageBlazor.Models;

public class Loan
{
    [Required]
    [Range(1, double.MaxValue, ErrorMessage = "Amount must be at least 1$")]
    public double Amount { get; set; }
    [Range(0.0, 100, MinimumIsExclusive = true, ErrorMessage = "Interest Rage must be between 0 and 100")]
    public double Rate { get; set; }
    [Range(1, 100, ErrorMessage = "Term must be between 1 and 100 years")]
    public int Term { get; set; }
    public double Payment { get; set; }
    public double TotalInterest { get; set; }
    public double TotalCost { get; set; }
    public List<LoanPayment> LoanPayments { get; set; } = [];
}