using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var colums = int.Parse(Console.ReadLine());

            var income = 0.0;

            if (type == "Premiere")
            {
                income = rows * colums * 12;
            }
            else if (type == "Normal")
            {
                income = rows * colums * 7.5;
            }
            else if (type == "Discount")
            {
                income = rows * colums * 5;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
