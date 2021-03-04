using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var change = double.Parse(Console.ReadLine());

            var convert = change * 100;
            var cents = (int)convert;
            var coins = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    coins++;
                    cents -= 200;
                    continue;
                }
                else if (cents - 100 >= 0)
                {
                    coins++;
                    cents -= 100;
                    continue;
                }
                else if (cents - 50 >= 0)
                {
                    coins++;
                    cents -= 50;
                    continue;
                }
                else if (cents - 20 >= 0)
                {
                    coins++;
                    cents -= 20;
                    continue;
                }
                else if (cents - 10 >= 0)
                {
                    coins++;
                    cents -= 10;
                    continue;
                }
                else if (cents - 5 >= 0)
                {
                    coins++;
                    cents -= 5;
                    continue;
                }
                else if (cents - 2 >= 0)
                {
                    coins++;
                    cents -= 2;
                    continue;
                }
                else if (cents - 1 >= 0)
                {
                    coins++;
                    cents -= 1;
                    continue;
                }
            }

            Console.WriteLine(coins);
        }
    }
}
