using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumber
{
    class Program
    {
        private static bool prime(int n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number:");
            int number = Int32.Parse(Console.ReadLine());
            bool k=prime(number);
            if (k) { Console.WriteLine("Is prime"); } else { Console.WriteLine("Not prime"); }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
