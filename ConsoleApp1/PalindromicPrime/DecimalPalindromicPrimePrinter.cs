using ConsoleApp1.Utility;
using System;

namespace ConsoleApp1.PalindromicPrime
{
    public class DecimalPalindromicPrimePrinter : BasePalindromicPrimePrinter
    {
        public override void PrintNumbers()
        {
            for (var p = 2; p <= 1000; p++)
                if (Prime.IsPrime(p) && Palindromic.IsPalindromic(p))
                    Console.Write(p + " ");
        }
    }
}
