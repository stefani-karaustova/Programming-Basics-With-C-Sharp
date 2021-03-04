using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var type = Console.ReadLine();
            var internet = Console.ReadLine();
            var months = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (time == "one")
            {
                switch (type)
                {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                }
            }

            if (internet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price > 10 && price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }

            var totalPrice = price * months;

            if (time == "two")
            {
                totalPrice = totalPrice - totalPrice * 0.0375;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
