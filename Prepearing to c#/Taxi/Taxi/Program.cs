using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        private static int Calculate(int kilom, int min)
        {
            int rezult = 0;
            if (kilom <= 5)
            {
                rezult += 20;

            }
            if (kilom > 5)
            {
                kilom = kilom - 5;
                rezult += 20;
                rezult += kilom*3;
            }
            rezult += min;
            return rezult;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the kilometeres:");
            int kilom = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minutes:");
            int minutes = Int32.Parse(Console.ReadLine());
            int rez = Calculate(kilom, minutes);
            Console.WriteLine("Summary: "+ rez+" hrn.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
