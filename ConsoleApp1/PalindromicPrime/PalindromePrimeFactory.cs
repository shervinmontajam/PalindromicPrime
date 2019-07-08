using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.PalindromicPrime
{
    public class PalindromePrimeFactory : IPalindromePrimeFactory
    {
        private readonly PalindromePrimeOptions _option;

        public PalindromePrimeFactory(PalindromePrimeOptions userInputOption)
        {
            _option = userInputOption;
        }

        public BasePalindromicPrimePrinter CreateObject()
        {
            var type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).FirstOrDefault(x => x.Name.Contains(Enum.GetName(typeof(PalindromePrimeOptions) , _option)) && x.IsClass);
            return (BasePalindromicPrimePrinter)Activator.CreateInstance(type);
        }
    }
}
