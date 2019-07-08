using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Utility
{
    public class BinaryConvertor
    {
        public static string ToBinary(int number, int toBase) => Convert.ToString(number, toBase);
    }
}
