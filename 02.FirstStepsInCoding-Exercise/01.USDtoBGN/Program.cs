using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usdCurrentCourse = 1.79549;
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * usdCurrentCourse;

            Console.WriteLine($"{bgn:f2}");
        }
    }
}
