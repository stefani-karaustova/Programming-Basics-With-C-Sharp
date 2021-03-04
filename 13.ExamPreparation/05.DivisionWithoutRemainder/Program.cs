using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dividedByTwo = 0.0;
            var dividedByThree = 0.0;
            var dividedByFour = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    dividedByTwo++;
                }
                if (number % 3 == 0)
                {
                    dividedByThree++;
                }
                if (number % 4 == 0)
                {
                    dividedByFour++;
                }
            }

            var resultForTwo = dividedByTwo / n * 100;
            var resultForThree = dividedByThree / n * 100;
            var resultForFour = dividedByFour / n * 100;

            Console.WriteLine($"{resultForTwo:f2}%");
            Console.WriteLine($"{resultForThree:f2}%");
            Console.WriteLine($"{resultForFour:f2}%");
        }
    }
}
