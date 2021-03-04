using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var mayAndOctoberStudio = 50;
            var mayAndOctoberApartment = 65;
            var juneAndSeptemberStudio = 75.2;
            var juneAndSeptemberApartment = 68.7;
            var julyAndAugustStudio = 76;
            var julyAndAugustApartment = 77;

            var season = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var totalMoneyStudio = 0.0;
            var totalMoneyApartment = 0.0;

            switch (season)
            {
                case "May":
                    totalMoneyStudio = nights * mayAndOctoberStudio;
                    totalMoneyApartment = nights * mayAndOctoberApartment;
                    if (nights > 7 && nights < 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights >= 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.3;
                    }
                    break;
                case "October":
                    totalMoneyStudio = nights * mayAndOctoberStudio;
                    totalMoneyApartment = nights * mayAndOctoberApartment;
                    if (nights > 7 && nights < 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.3;
                    }
                    break;
                case "June":
                    totalMoneyStudio = nights * juneAndSeptemberStudio;
                    totalMoneyApartment = nights * juneAndSeptemberApartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.2;
                    }
                    break;
                case "September":
                    totalMoneyStudio = nights * juneAndSeptemberStudio;
                    totalMoneyApartment = nights * juneAndSeptemberApartment;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.2;
                    }
                    break;
                case "July":
                    totalMoneyStudio = nights * julyAndAugustStudio;
                    totalMoneyApartment = nights * julyAndAugustApartment;
                    break;
                case "August":
                    totalMoneyStudio = nights * julyAndAugustStudio;
                    totalMoneyApartment = nights * julyAndAugustApartment;
                    break;
            }

            if (nights > 14)
            {
                totalMoneyApartment -= totalMoneyApartment * 0.1;
            }

            Console.WriteLine($"Apartment: {totalMoneyApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio:f2} lv.");
        }
    }
}
