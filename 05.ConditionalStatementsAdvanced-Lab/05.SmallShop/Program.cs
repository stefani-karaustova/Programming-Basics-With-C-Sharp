using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantiti = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quantiti * 0.5;
                }
                else if (product == "water")
                {
                    price = quantiti * 0.8;
                }
                else if (product == "beer")
                {
                    price = quantiti * 1.2;
                }
                else if (product == "sweets")
                {
                    price = quantiti * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = quantiti * 1.6;
                }
            }

            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantiti * 0.4;
                }
                else if (product == "water")
                {
                    price = quantiti * 0.7;
                }
                else if (product == "beer")
                {
                    price = quantiti * 1.15;
                }
                else if (product == "sweets")
                {
                    price = quantiti * 1.3;
                }
                else if (product == "peanuts")
                {
                    price = quantiti * 1.5;
                }
            }

            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    price = quantiti * 0.45;
                }
                else if (product == "water")
                {
                    price = quantiti * 0.7;
                }
                else if (product == "beer")
                {
                    price = quantiti * 1.1;
                }
                else if (product == "sweets")
                {
                    price = quantiti * 1.35;
                }
                else if (product == "peanuts")
                {
                    price = quantiti * 1.55;
                }
            }

            Console.WriteLine(price);
        }
    }
}
