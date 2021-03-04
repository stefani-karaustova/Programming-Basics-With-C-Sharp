using System;

namespace _03.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;

            for (int i = 1; i <= number; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;

                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");

            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
