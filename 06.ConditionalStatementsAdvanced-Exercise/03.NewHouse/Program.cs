using System;

namespace _03.NewHouse
{
    class Program
    {
        static double priceOfRoses = 5;
        static double priceOfDahlias = 3.8;
        static double priceOfTulips = 2.8;
        static double priceOfNarcissus = 3;
        static double priceOfGladiolus = 2.5;

        static void Main(string[] args)
        {
            var flowers = Console.ReadLine();
            var quantiti = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var totalPrice = 0.0;

            if (flowers == "Roses")
            {
                if (quantiti > 80)
                {
                    totalPrice -= priceOfRoses * quantiti * 0.1;
                }
                totalPrice += priceOfRoses * quantiti;
            }

            else if (flowers == "Dahlias")
            {
                if (quantiti > 90)
                {
                    totalPrice -= priceOfDahlias * quantiti * 0.15;
                }
                totalPrice += priceOfDahlias * quantiti;
            }

            else if (flowers == "Tulips")
            {
                if (quantiti > 80)
                {
                    totalPrice -= priceOfTulips * quantiti * 0.15;
                }
                totalPrice += priceOfTulips * quantiti;
            }

            else if (flowers == "Narcissus")
            {
                if (quantiti < 120)
                {
                    totalPrice += priceOfNarcissus * quantiti * 0.15;
                }
                totalPrice += priceOfNarcissus * quantiti;
            }

            else
            {
                if (quantiti < 80)
                {
                    totalPrice += priceOfGladiolus * quantiti * 0.2;
                }
                totalPrice += priceOfGladiolus * quantiti;
            }

            if (budget >= totalPrice)
            {
                var moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {quantiti} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                var moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
