using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task1Advance2
    {
        internal void LoadAmount()
        {
            // Monthly payment
            double monthlyPayment = 750; // RM 750

            // Annual interest rate
            double annualInterestRate = 6.5; // 6.5%

            // Loan term in years
            int loanTermYears = 20;

            // Calculate monthly interest rate
            double monthlyInterestRate = annualInterestRate / 100 / 12;

            // Calculate total number of payments
            int numberOfPayments = loanTermYears * 12;

            // Calculate the maximum loan amount
            double loanAmount = CalculateLoanAmount(monthlyPayment, monthlyInterestRate, numberOfPayments);

            Console.WriteLine("Task 1 (Advance 2)");
            // Output the loan amount
            Console.WriteLine("Loan Amount to borrow: " + Math.Round(loanAmount, 2));
        }

        static double CalculateLoanAmount(double monthlyPayment, double monthlyInterestRate, int numberOfPayments)
        {
            // Calculate the loan amount using the rearranged EMI formula
            double numerator = monthlyPayment * (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);
            double denominator = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments);
            double loanAmount = numerator / denominator;

            return loanAmount;
        }
    }
}
