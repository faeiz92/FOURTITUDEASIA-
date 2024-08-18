using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task1Advance1
    {
        internal void LoanPeriod()
        {
            // principalAmountBorrowed amount
            double principalAmountBorrowed = 95000; // RM 95,000

            // Annual interest rate
            double annualInterestRate = 0; // 6.5%

            // Monthly payment
            double monthlyPayment = 1750; // RM 1,750

            if (principalAmountBorrowed >= 5000 && principalAmountBorrowed <= 20000)
                annualInterestRate = 8;

            else if (principalAmountBorrowed >= 20001 && principalAmountBorrowed <= 50000)
                annualInterestRate = 7;

            else if (principalAmountBorrowed >= 50001 && principalAmountBorrowed <= 100000)
                annualInterestRate = 6.5;

            // Calculate monthly interest rate
            double monthlyInterestRate = annualInterestRate / 100 / 12;

            // Calculate the number of payments (months) needed
            int numberOfPayments = CalculateLoanPeriod(principalAmountBorrowed, monthlyInterestRate, monthlyPayment);

            // Convert months to years
            double loanTermYears = numberOfPayments / 12.0;

            // Output the loan period in years
            Console.WriteLine("Task 1 (Advance 1)");
            Console.WriteLine("Loan period in years: " + Math.Round(loanTermYears, 2)  + " years");
        }

        static int CalculateLoanPeriod(double principalAmountBorrowed, double monthlyInterestRate, double monthlyPayment)
        {
            // Compute the EMI ratio A
            double A = monthlyPayment / (principalAmountBorrowed * monthlyInterestRate);

            // Calculate the number of payments (months) using logarithms
            double numerator = Math.Log(A / (A - 1));
            double denominator = Math.Log(1 + monthlyInterestRate);
            int numberOfPayments = (int)Math.Ceiling(numerator / denominator);

            return numberOfPayments;
        }
    }
}
