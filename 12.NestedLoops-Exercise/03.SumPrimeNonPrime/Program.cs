using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var sumOdd = 0;
            var sumPrime = 0;

            while (command != "stop")
            {
                var number = int.Parse(command);
                var count = 0;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (number != 1 && count == 0)
                {
                    sumPrime += number;
                }
                else
                {
                    sumOdd += number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOdd}");
        }
    }
}
