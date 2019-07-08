using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.PalindromicPrime;
using Xunit;

namespace PalindromicPrime_Test.PalindromicPrime
{
    public class PalindromePrimeFactoryTests
    {
        [Fact]
        public void CreateObject_InputIsDecimalPalindromicPrimePrinter_IsAssignableToBasePalindromicPrimePrinter()
        {
            IPalindromePrimeFactory factory = new PalindromePrimeFactory(PalindromePrimeOptions.DecimalPalindromicPrimePrinter);

            var basePalindromicPrimePrinter = factory.CreateObject();

            Assert.IsAssignableFrom<BasePalindromicPrimePrinter>(basePalindromicPrimePrinter);
        }
    }
}
