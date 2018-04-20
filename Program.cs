using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEnumAttributes.Enums;
using TestEnumAttributes.Extensions;

namespace TestEnumAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenuOptions options = MainMenuOptions.Gallery;
            Console.WriteLine(options.GetXpathValue());
            Console.ReadKey();
        }
    }
}
