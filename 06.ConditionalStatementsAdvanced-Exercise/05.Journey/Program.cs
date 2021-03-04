using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var totalMoney = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else
                {
                    totalMoney = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    totalMoney = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {totalMoney:f2}");
                }
                else
                {
                    totalMoney = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {totalMoney:f2}");
                }
            }

            else
            {
                totalMoney = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {totalMoney:f2}");
            }
        }
    }
}
