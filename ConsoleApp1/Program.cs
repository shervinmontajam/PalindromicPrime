using System;
using System.Linq;
using ConsoleApp1.PalindromicPrime;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main()
        {
            string userInput;
            do
            {
                userInput = DisplayMenu();
                var listOfOptions = Enum.GetValues(typeof(PalindromePrimeOptions)).Cast<PalindromePrimeOptions>().Select(v => ((int)v).ToString()).ToList();
                if (!listOfOptions.Contains(userInput))
                    continue;

                IPalindromePrimeFactory factory = new PalindromePrimeFactory((PalindromePrimeOptions)Convert.ToInt32(userInput));
                BasePalindromicPrimePrinter basePalindromicPrimePrinter = factory.CreateObject();
                basePalindromicPrimePrinter.PrintNumbers();

            } while (userInput != "4");
        }

        private static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Palindromic Prime");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Print Decimal Numbers");
            Console.WriteLine("2. Print Binary 16 Numbers");
            Console.WriteLine("3. Print Binary 2 Numbers");
            Console.WriteLine("4. Exit");

            return Console.ReadLine();
        }


    }
}
