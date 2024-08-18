using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task1Basic1
    {
        

      
        internal void  MonthlyInstalment()
        {
            //Console.WriteLine("Please insert loan amount");
            //principalAmountBorrowed =  Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please insert period");
            //installmentPeriod = Convert.ToInt32(Console.ReadLine());
            double monthlyInstallment = 0;
            double principalAmountBorrowed = 95000;
            double monthlyInterestRate = 0;
            double annualInterestRate = 0;
            int numberOfPayment = 0;
            int installmentPeriod = 5;

            if (principalAmountBorrowed >= 5000 && principalAmountBorrowed <= 20000)
                annualInterestRate = 8;
            
            else if(principalAmountBorrowed >= 20001 && principalAmountBorrowed <= 50000)
                annualInterestRate = 7;

            else if (principalAmountBorrowed >= 50001 && principalAmountBorrowed <= 100000)
                annualInterestRate = 6.5;

            monthlyInterestRate = annualInterestRate / 100 / 12;

            // Bilangan pembayaran total
            int totalPayments = 12 * installmentPeriod;

            double monthlyOfPayment  = CalculateMonthlyPayment(monthlyInstallment, principalAmountBorrowed, monthlyInterestRate, annualInterestRate, numberOfPayment, installmentPeriod, totalPayments);

            // Kira ansuran bulanan
            


            Console.WriteLine("Task 1 (Basic 1)");
            Console.WriteLine("Monthly repayment is :" + Math.Round(monthlyOfPayment, 2));
             

        }

        static double CalculateMonthlyPayment(double monthlyInstallment, double principalAmountBorrowed, double monthlyInterestRate, double nnualInterestRate, int numberOfPayment, int installmentPeriod, double totalPayments)
        {
            double monthlyPayment = (principalAmountBorrowed * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalPayments)) /
                                    (Math.Pow(1 + monthlyInterestRate, totalPayments) - 1);

            return monthlyPayment;
        }
    }
}
