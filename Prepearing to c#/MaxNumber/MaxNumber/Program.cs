using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            double[] array = new double[2];
            string line = Console.ReadLine();
            string[] splitLine = line.Split(' ');
            int i = 0;
            foreach (var sLine in splitLine)
            {
                array[i] = Int32.Parse(sLine);
                i++;
            }
            if (array[0]> array[1])
            {
                Console.WriteLine("Max: "+array[0]);
            }
            else if(array[0] == array[1])
            {
                Console.WriteLine("This numbers are identical");
            }
            else
            {
                Console.WriteLine("Max: " + array[1]);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
