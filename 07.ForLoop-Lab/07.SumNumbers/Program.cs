using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());

                sum += inputNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
