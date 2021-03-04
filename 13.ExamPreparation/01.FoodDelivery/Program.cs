using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var chickenMenu = int.Parse(Console.ReadLine());
            var fishMenu = int.Parse(Console.ReadLine());
            var veganMenu = int.Parse(Console.ReadLine());

            var priceForChicken = chickenMenu * 10.35;
            var priceForFish = fishMenu * 12.4;
            var priceForVegan = veganMenu * 8.15;

            var totalPrice = priceForChicken + priceForFish + priceForVegan;
            var desert = totalPrice * 0.2;
            var delivery = 2.5;

            var totalSum = totalPrice + desert + delivery;

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
