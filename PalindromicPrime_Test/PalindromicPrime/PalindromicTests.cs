using ConsoleApp1.Utility;
using Xunit;


namespace PalindromicPrime_Test.PalindromicPrime
{
    public class PalindromicTests
    {
        [Fact]
        public void IsPalindromic_InputIsNotPalindromicNumber_ReturnsFalse()
        {
            var result = Palindromic.IsPalindromic(0);

            Assert.False(result);
        }


        [Fact]
        public void IsPalindromic_InputIsPalindromicNumber_ReturnsTrue()
        {
            var result = Palindromic.IsPalindromic(101);

            Assert.True(result);
        }


    }
}