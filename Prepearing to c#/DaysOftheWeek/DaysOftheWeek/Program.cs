using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOftheWeek
{
    class Program
    {
        private static void ShowTheDay(int number)
        {
            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(days[number-1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the day of the week:");
            int number = Int32.Parse(Console.ReadLine());
            ShowTheDay(number);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
