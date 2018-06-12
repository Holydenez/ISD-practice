using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    class Program
    {
        private static void ShowSeason(int number)
        {
            if ((number == 1) || (number == 2) || (number == 12)) { Console.WriteLine("Winter"); }
            else if ((number >= 3) && (number <= 5)) { Console.WriteLine("Spring"); }
            else if ((number >= 6) && (number <= 8)) { Console.WriteLine("Summer"); }
            else if ((number >= 9) && (number <= 11)) { Console.WriteLine("Fall"); }
            else { Console.WriteLine("There is no month with number '"+ number+ "' on our planet"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of month:");
            int number = Int32.Parse(Console.ReadLine());
            ShowSeason(number);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
