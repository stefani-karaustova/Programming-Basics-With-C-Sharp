using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var numberOfPeople = int.Parse(Console.ReadLine());

            var springPrice = 3000;
            var summerAndAutumnPrice = 4200;
            var winterPrice = 2600;
            var totalMoney = 0.0;

            switch (season)
            {
                case "Spring":
                    totalMoney = springPrice;
                    break;
                case "Summer":
                    totalMoney = summerAndAutumnPrice;
                    break;
                case "Autumn":
                    totalMoney = summerAndAutumnPrice;
                    break;
                case "Winter":
                    totalMoney = winterPrice;
                    break;
            }

            if (numberOfPeople <= 6)
            {
                totalMoney -= totalMoney * 0.1;
            }
            else if (numberOfPeople >= 7 && numberOfPeople <= 11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else
            {
                totalMoney -= totalMoney * 0.25;
            }

            if (numberOfPeople % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }

            if (budget >= totalMoney)
            {
                var moneyLeft = budget - totalMoney;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                var neededMoney = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}
