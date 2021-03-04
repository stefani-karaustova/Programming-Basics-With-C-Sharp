using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDays = int.Parse(Console.ReadLine());
            var pastryChefs = int.Parse(Console.ReadLine());
            var numberOfCakes = int.Parse(Console.ReadLine());
            var numberOfWaffles = int.Parse(Console.ReadLine());
            var numberOfPancakes = int.Parse(Console.ReadLine());

            var priceForCake = 45;
            var priceForWaffle = 5.8;
            var priceForPancake = 3.2;

            var totalPriceForCakes = numberOfCakes * priceForCake;
            var totalPriceForWaffles = numberOfWaffles * priceForWaffle;
            var totalPriceForPancakes = numberOfPancakes * priceForPancake;

            var totalPricePerDay = (totalPriceForCakes + totalPriceForWaffles + totalPriceForPancakes) * pastryChefs;
            var totalSumFromCampaign = totalPricePerDay * totalDays;
            var costForCampaign = totalSumFromCampaign - (totalSumFromCampaign / 8);

            Console.WriteLine($"{costForCampaign:f2}");
        }
    }
}
