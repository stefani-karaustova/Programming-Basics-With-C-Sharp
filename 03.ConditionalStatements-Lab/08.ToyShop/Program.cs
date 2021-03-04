using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfPuzzle = 2.6;
            var priceOfDoll = 3;
            var priceOfBear = 4.10;
            var priceOfMinion = 8.20;
            var priceOfTruck = 2;

            var priceOfVacation = double.Parse(Console.ReadLine());
            var puzzles = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var bears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            var totalPrice = (puzzles * priceOfPuzzle)
                            + (dolls * priceOfDoll)
                            + (bears * priceOfBear)
                            + (minions * priceOfMinion)
                            + (trucks * priceOfTruck);

            var totalCount = puzzles + dolls + bears + minions + trucks;

            if (totalCount >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }

            totalPrice = totalPrice * 0.90;

            if (totalPrice >= priceOfVacation)
            {
                var moneyLeft = totalPrice - priceOfVacation;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                var neededMoney = priceOfVacation - totalPrice;

                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
