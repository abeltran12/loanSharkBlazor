using MortageBlazor.Models;

namespace MortageBlazor.Helpers;

public static class LoanUtilities
{
    /// <summary>
    /// Calculates a payment for a simple interes loan
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="rate"></param>
    /// <param name="term"></param>
    /// <returns>A monthly payment as a double</returns>
    public static double CalcPayment(double amount, double rate, double term)
    {
        var monthlyRate = CalcMonthlyRate(rate);
        var months = term * 12;
        var payment = amount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -months));

        return payment;
    }

    /// <summary>
    /// Calculate the monthly payment schedule for a loan
    /// </summary>
    /// <param name="loan"></param>
    /// <returns>a loan object</returns>
    public static Loan CalculatePayments(Loan loan)
    {
        loan.LoanPayments.Clear();

        //Calculate monthly payment
        loan.Payment = CalcPayment(loan.Amount, loan.Rate, loan.Term);

        var loanMonths = loan.Term * 12;

        //variables to hold the total interest and balance
        double balance = loan.Amount;
        double totalInterest = 0;
        double monthlyPrincipal = 0;
        double monthlyInterest = 0;
        double monthlyRate = CalcMonthlyRate(loan.Rate);

        for (int month = 1; month <= loanMonths; month++)
        {
            monthlyInterest = CalculateMonthlyInterest(balance, monthlyRate);
            totalInterest += monthlyInterest;
            monthlyPrincipal = loan.Payment - monthlyInterest;
            balance -= monthlyPrincipal;

            LoanPayment loanPayment = new();

            loanPayment.Month = month;
            loanPayment.Payment = loan.Payment;
            loanPayment.MonthlyPrincipal = monthlyPrincipal;
            loanPayment.MonthlyInterest = monthlyInterest;
            loanPayment.TotalInterest = totalInterest;
            loanPayment.Balance = balance < 0 ? 0 : balance;

            loan.LoanPayments.Add(loanPayment);
        }

        loan.TotalInterest = totalInterest;
        loan.TotalCost = loan.Amount + totalInterest;

        return loan;
    }
    
    public static double CalculateMonthlyInterest(double balance, double monthlyRate)
    {
        return balance * monthlyRate;
    }
    
    private static double CalcMonthlyRate(double rate)
    {
        return rate / 1200;
    }
}