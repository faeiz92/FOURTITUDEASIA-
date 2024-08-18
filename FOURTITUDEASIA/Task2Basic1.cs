using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task2Basic1
    {
        internal void SpecialDigit()
        {
            // Example digit string
            string digits = "9729923302749217";

            // Ensure that the digit string is long enough for this example
            if (digits.Length < 10)
            {
                Console.WriteLine("The digit string is too short.");
                return;
            }

            int A = CalculateSum(digits, 10, 1);
            int B = CalculateSum(digits, 8, 2);
            int C = CalculateSum(digits, 6, 3);
            int D = CalculateSum(digits, 4, 4);
            int E = CalculateSum(digits, 2, 5);

            int finalSum = A + B + C + D + E;

            int specialDigit = SumDigitsUntilSingle(finalSum);

            Console.WriteLine("Task 2 (Basic 1)");
            Console.WriteLine("The special digit is: " + specialDigit);
        }

        static int CalculateSum(string digits, int multiplier, int startPosition)
        {
            int sum = 0;
            for (int i = startPosition - 1; i < digits.Length; i += 5)
            {
                // Convert character to integer and multiply
                int digit = digits[i] - '0';
                sum += digit * multiplier;
            }
            return sum;
        }

        static int SumDigitsUntilSingle(int number)
        {
            while (number >= 10)
            {
                number = SumOfDigits(number);
            }
            return number;
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
