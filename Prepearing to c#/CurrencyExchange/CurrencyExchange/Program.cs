using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Money
    {
        public double value;
        public string currency;
        public Money(double value, string currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
    class Program
    {
        private static void Convert(Money money)
        {
            double dollarkurs = 27.5;
            double eurokurs = 31.2;
            double second_value;
            double third_value;
            if (money.currency.Equals("hryvna"))
            {
                second_value = money.value * dollarkurs;//dollar
                third_value = money.value * eurokurs;//euro
                Console.WriteLine("In "+ money.value+ " hryvnas, there are: "+ second_value+" dollars and "+ third_value+" euros.");
            }
            else if (money.currency.Equals("dollar"))
            {
                second_value = money.value / dollarkurs;//hryvna
                third_value = second_value * eurokurs;//euro
                Console.WriteLine("In " + money.value + " dollars, there are: " + second_value + " hryvnas and " + third_value + " euros.");
            }
            else if (money.currency.Equals("euro"))
            {
                second_value = money.value / eurokurs;//hryvna
                third_value = second_value * dollarkurs;//dollar
                Console.WriteLine("In " + money.value + " euros, there are: " + second_value + " hryvnas and " + third_value + " dollars.");
            }
            else Console.WriteLine("Error");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:");
            double value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose the currency:");
            Console.WriteLine("1. Hryvna");
            Console.WriteLine("2. Dollar");
            Console.WriteLine("3. Euro");
            int caseSwitch = Int32.Parse(Console.ReadLine()); 
            switch (caseSwitch)
            {
                case 1:
                    Money hryvna = new Money(value, "hryvna");
                    Convert(hryvna);
                    break;
                case 2:
                    Money dollar = new Money(value, "dollar");
                    Convert(dollar);
                    break;
                case 3:
                    Money euro = new Money(value, "euro");
                    Convert(euro);
                    break;
                default:
                    Console.WriteLine("There are not such kind of currency");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
