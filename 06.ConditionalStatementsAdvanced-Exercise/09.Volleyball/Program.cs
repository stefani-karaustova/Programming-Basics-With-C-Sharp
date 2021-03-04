using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekends = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekends;
            var weekendsPlayInSofia = weekendsInSofia * 3.0 / 4.0;
            var holidaysInSofia = holidays * 2.0 / 3.0;
            var plays = holidaysInSofia + weekendsPlayInSofia + weekends;

            if (year == "leap")
            {
                plays *= 1.15;
                Console.WriteLine($"{Math.Floor(plays)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(plays)}");
            }
        }
    }
}
