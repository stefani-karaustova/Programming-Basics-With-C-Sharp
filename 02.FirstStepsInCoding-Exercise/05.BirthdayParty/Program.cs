using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var rent = double.Parse(Console.ReadLine());

            var priceForCake = rent * 0.2;
            var priceForDrinks = priceForCake - (priceForCake * 0.45);
            var priceForAnimator = rent / 3;

            var totalPrice = rent + priceForCake + priceForDrinks + priceForAnimator;

            Console.WriteLine(totalPrice);
        }
    }
}
