using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceOfWashingMachine = double.Parse(Console.ReadLine());
            var priceOfToys = double.Parse(Console.ReadLine());

            var toysCount = 0;
            var savedMoney = 0.0;
            var firstAmount = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    savedMoney += firstAmount;
                    firstAmount += 10;
                }
            }

            savedMoney -= age / 2;

            savedMoney += toysCount * priceOfToys;
            var moneyLeft = savedMoney - priceOfWashingMachine;
            var moneyNeeded = priceOfWashingMachine - savedMoney;

            if (savedMoney >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
