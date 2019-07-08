using System.Linq;

namespace ConsoleApp1.Utility
{
    public class Prime
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            return Enumerable.Range(1, number).Where(x => number % x == 0).SequenceEqual(new[] { 1, number });
        }
    }
}
