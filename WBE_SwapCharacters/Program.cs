/**
 * Given any string swap its neighboring charactesr.
 * ie: PANAMA returns APANAM
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_SwapCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a test string\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine("\nSwapped string: " + SwapCharacters(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        private static string SwapCharacters(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                result +=  new string (input.Substring(i, 2).Reverse().ToArray());
            }
            if (input.Length % 2 == 1)
            {
                result += input[input.Length - 1];
            }
            return result;
        }
    }
}
