using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORTITUDEASIA
{
    internal class Task3Basic1
    {
        public static char[] orderByAlgorithm(char[] input, int ordering)
        {
            // Convert the input array to a list for easy removal of elements
            List<char> characters = new List<char>(input);
            List<char> result = new List<char>();
            int index = 0;

            while (characters.Count > 0)
            {
                // Calculate the next index to pick
                index = (index + ordering - 1) % characters.Count;
                char picked = characters[index];

                // Add the picked character to the result
                result.Add(picked);

                // Remove the picked character
                characters.RemoveAt(index);

                // Add "-" after every 3rd character in the result list
                if (result.Count % 3 == 0)
                {
                    result.Add('-');
                }
            }

            // Convert the result list back to an array and return
            return result.ToArray();
        }

        internal void ArrangeCharacter()
        {
            char[] input = "ABCDEFGHIJ".ToCharArray();
            char[] output = orderByAlgorithm(input, 7);
            Console.WriteLine("Task 3 (Basic 1)");
            Console.WriteLine(new string(output));  // Output should be: "GDB-ACF-JEH-I"
        }
    }
}
