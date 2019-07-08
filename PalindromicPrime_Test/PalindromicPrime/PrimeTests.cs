using ConsoleApp1.Utility;
using Xunit;


namespace PalindromicPrime_Test.PalindromicPrime
{
    public class PrimeTests
    {

        [Fact]
        public void IsPrime_InputIsNotPrimeNumber_ReturnsFalse()
        {
            var result = Prime.IsPrime(-4);

            Assert.False(result);
        }


        [Fact]
        public void IsPrime_InputIsPrimeNumber_ReturnsTrue()
        {
            var result = Prime.IsPrime(3);

            Assert.True(result);
        }
    }
}