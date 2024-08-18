using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task3Advance1
    {
        internal void ArrangeCharacter()
        {
            string scrambledMessage = "e  rbml s nngeshsr etaet.loaldtryadaimt di ghtoeaeuse aC cuciy afskh ss t ovgo tna atstanmeempaa  Itrf oee!oenotou ";
            int ordering = 24;

            char[] originalMessage = ReverseOrderByAlgorithm(scrambledMessage.ToCharArray(), ordering);
            Console.WriteLine("Task 3 (Advance 1)");
            Console.WriteLine(new string(originalMessage));
        }

        public static char[] ReverseOrderByAlgorithm(char[] input, int ordering)
        {
            // The length of the scrambled message
            int length = input.Length;
            List<char> result = new List<char>(new char[length]);

            // Use a list to track available positions
            List<int> positions = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                positions.Add(i);
            }

            int index = 0;

            // Reconstruct the original message by reversing the process
            while (positions.Count > 0)
            {
                // Calculate the index to pick for placing characters
                index = (index + ordering - 1) % positions.Count;
                int pos = positions[index];
                result[pos] = input[positions[index]];

                // Remove the used position
                positions.RemoveAt(index);
            }

            return result.ToArray();
        }
    }
}
