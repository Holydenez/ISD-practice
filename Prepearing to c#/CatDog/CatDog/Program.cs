using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'meow' or 'woof':");
            string command = Console.ReadLine();
            if (command.Equals("meow"))
            {
                Console.WriteLine("Feed the cat");
            }
            else if (command.Equals("woof"))
            {
                Console.WriteLine("Go for a walk with the dog");
            }
            else
            {
                Console.WriteLine("Wrong command");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
