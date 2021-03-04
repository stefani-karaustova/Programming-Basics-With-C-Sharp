using System;

namespace _02.EqualSumEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                var evenSum = 0;
                var oddSum = 0;
                var currentNumber = i;
                var count = 0;

                while (currentNumber != 0)
                {
                    var digit = currentNumber % 10;

                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                    currentNumber = currentNumber / 10;
                    count++;
                }

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
