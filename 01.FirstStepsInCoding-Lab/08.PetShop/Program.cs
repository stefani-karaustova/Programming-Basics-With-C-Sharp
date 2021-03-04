using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = int.Parse(Console.ReadLine());
            var otherAnimals = int.Parse(Console.ReadLine());

            var dogFood = dogs * 2.5;
            var otherFood = otherAnimals * 4;

            var price = dogFood + otherFood;

            Console.WriteLine($"{price} lv.");
        }
    }
}
