namespace ConsoleApp1.Utility
{
    public class Palindromic
    {
        public static bool IsPalindromic(int number)
        {
            if (number < 2)
                return false;

            var numString = number.ToString();

            for (var i = 0; i < numString.Length / 2; i++)
                if (numString[i] != numString[(numString.Length - 1) - i])
                    return false;

            return true;
        }
    }
}
