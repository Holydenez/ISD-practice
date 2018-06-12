using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodorBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 or 0:");
            int number = Int32.Parse(Console.ReadLine());
            if (number == 1) { Console.WriteLine("Good"); }else if (number == 0) { Console.WriteLine("Bad"); }else { Console.WriteLine("Error"); }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
