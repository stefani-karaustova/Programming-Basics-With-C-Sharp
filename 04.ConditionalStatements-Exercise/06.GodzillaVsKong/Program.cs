using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieBudged = double.Parse(Console.ReadLine());
            var numberOfExtras = int.Parse(Console.ReadLine());
            var priceForClothes = double.Parse(Console.ReadLine());

            var decor = movieBudged * 0.1;

            if (numberOfExtras >= 150)
            {
                priceForClothes *= 0.9;
            }

            var finalPriceForClothes = numberOfExtras * priceForClothes;
            var finalSum = decor + finalPriceForClothes;

            if (finalSum <= movieBudged)
            {
                var moneyLeft = movieBudged - finalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

            else
            {
                var neededMoney = finalSum - movieBudged;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
        }
    }
}
