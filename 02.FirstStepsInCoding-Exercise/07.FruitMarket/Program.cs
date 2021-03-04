using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceForStrawberries = double.Parse(Console.ReadLine());
            var bananas = double.Parse(Console.ReadLine());
            var oranges = double.Parse(Console.ReadLine());
            var raspberries = double.Parse(Console.ReadLine());
            var strawberries = double.Parse(Console.ReadLine());

            var priceForRaspberries = priceForStrawberries / 2;
            var priceForOranges = priceForRaspberries - (priceForRaspberries * 0.4);
            var priceForBananas = priceForRaspberries - (priceForRaspberries * 0.8);

            var totalSumForStrawerries = strawberries * priceForStrawberries;
            var totalSumForRaspberries = raspberries * priceForRaspberries;
            var totalSumForBananas = bananas * priceForBananas;
            var totalSumForOranges = oranges * priceForOranges;

            var totalSum = totalSumForBananas + totalSumForOranges + totalSumForRaspberries + totalSumForStrawerries;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
