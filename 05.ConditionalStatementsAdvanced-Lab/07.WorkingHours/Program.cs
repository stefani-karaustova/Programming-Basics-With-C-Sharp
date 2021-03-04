using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday"
                || day == "Tuesday"
                || day == "Wednesday"
                || day == "Thursday"
                || day == "Friday"
                || day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
