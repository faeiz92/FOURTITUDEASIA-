using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task2Advance1
    {
        internal void SpecialDigit()
        {
            int[] frequency = new int[10]; // To count occurrences of each special digit (0-9)

            for (int num = 201; num <= 999; num++)
            {
                string digits = num.ToString();
                int A = CalculateSum(digits, 10, 1);
                int B = CalculateSum(digits, 8, 2);
                int C = CalculateSum(digits, 6, 3);
                int D = CalculateSum(digits, 4, 4);
                int E = CalculateSum(digits, 2, 5);

                int finalSum = A + B + C + D + E;
                int specialDigit = SumDigitsUntilSingle(finalSum);

                // Count the frequency of each special digit
                frequency[specialDigit]++;
            }

            Console.WriteLine("Task 2 (Advance 1)");
            // Print out the results
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} occurrences");
            }

            // Determine the most and least frequent special digits
            int maxFrequency = -1, minFrequency = int.MaxValue;
            int mostFrequentDigit = -1, leastFrequentDigit = -1;

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > maxFrequency)
                {
                    maxFrequency = frequency[i];
                    mostFrequentDigit = i;
                }
                if (frequency[i] < minFrequency)
                {
                    minFrequency = frequency[i];
                    leastFrequentDigit = i;
                }
            }

            Console.WriteLine($"Most frequent digit: {mostFrequentDigit} with {maxFrequency} occurrences");
            Console.WriteLine($"Least frequent digit: {leastFrequentDigit} with {minFrequency} occurrences");
        }

        static int CalculateSum(string digits, int multiplier, int startPosition)
        {
            int sum = 0;
            for (int i = startPosition - 1; i < digits.Length; i += 5)
            {
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
