using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());

            var price = 0.0;
            var productCount = 0;

            while (true)
            {
                var productName = Console.ReadLine();

                if (productName == "Stop")
                {
                    break;
                }

                var productPrice = double.Parse(Console.ReadLine());

                productCount++;

                if (productCount % 3 == 0)
                {
                    productPrice /= 2;
                }

                if (budget - productPrice < 0)
                {
                    var neededMoney = productPrice - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    Environment.Exit(0);
                }

                budget -= productPrice;
                price += productPrice;
            }

            Console.WriteLine($"You bought {productCount} products for {price:f2} leva.");
        }
    }
}
