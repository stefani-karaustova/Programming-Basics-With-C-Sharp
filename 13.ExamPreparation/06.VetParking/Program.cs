using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());

            var totalSum = 0.0;

            for (int day = 1; day <= days; day++)
            {
                var daySum = 0.0;

                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        daySum += 2.5;

                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        daySum += 1.25;
                    }
                    else
                    {
                        daySum += 1;
                    }
                }

                totalSum += daySum;

                Console.WriteLine($"Day: {day} - {daySum:f2} leva");
            }

            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
