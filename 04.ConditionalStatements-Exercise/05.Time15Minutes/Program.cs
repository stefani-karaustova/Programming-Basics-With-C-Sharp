using System;

namespace _05.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sumOfMinutes = (hours * 60) + minutes;
            sumOfMinutes = sumOfMinutes + 15;

            int resultHour = sumOfMinutes / 60;
            int resultMinutes = sumOfMinutes % 60;

            Console.WriteLine($"{resultHour % 24}:{resultMinutes:D2}");
        }
    }
}
