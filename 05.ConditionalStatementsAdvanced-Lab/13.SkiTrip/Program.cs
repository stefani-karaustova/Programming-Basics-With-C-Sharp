using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var hotelRoom = Console.ReadLine();
            var feedback = Console.ReadLine();

            var priceForNight = 0.0;
            var discount = 0.0;

            switch (hotelRoom)
            {
                case "room for one person":
                    priceForNight = 18;
                    break;

                case "apartment":
                    priceForNight = 25;
                    if (days < 10)
                    {
                        discount = 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.5;
                    }
                    break;

                case "president apartment":
                    priceForNight = 35;
                    if (days < 10)
                    {
                        discount = 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.2;
                    }
                    break;
            }

            var totalPrice = priceForNight * (days - 1);
            totalPrice = totalPrice - totalPrice * discount;

            if (feedback == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else if (feedback == "negative")
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
