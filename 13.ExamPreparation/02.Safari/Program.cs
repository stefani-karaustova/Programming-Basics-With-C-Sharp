using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var fuel = double.Parse(Console.ReadLine());
            var dayOfWeek = Console.ReadLine();

            var priceForFuel = fuel * 2.1;
            var totalPrice = priceForFuel + 100;

            switch (dayOfWeek)
            {
                case "Saturday":
                    totalPrice *= 0.9;
                    break;
                case "Sunday":
                    totalPrice *= 0.8;
                    break;
            }

            if (totalPrice <= budget)
            {
                var moneyLeft = budget - totalPrice;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                var moneyNeeded = Math.Abs(totalPrice - budget);
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
