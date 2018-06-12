using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        private static void ThrowDice(int bet)
        {
            Random rnd = new Random();
            int dice_number = rnd.Next(1, 13);
            Console.WriteLine("the number on the dice is :" + dice_number);
            if ((dice_number>=1)&&(dice_number<=5))
            {
                Console.WriteLine("You lost.");
                bet = 0;
            }
            else if ((dice_number >= 6) && (dice_number <= 8))
            {
                Console.WriteLine("Your bet didnt change.");
            }
            else if ((dice_number >= 9) && (dice_number <= 11))
            {
                Console.WriteLine("Your bet has doubled.");
                bet = bet * 2;
            }
            else if (dice_number==12)
            {
                Console.WriteLine("Your bet has increased tenfold.");
                bet = bet * 10;
            }
            Console.WriteLine("Your bet is now: "+ bet);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your bet:");
            int bet = Int32.Parse(Console.ReadLine());
            ThrowDice(bet);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
