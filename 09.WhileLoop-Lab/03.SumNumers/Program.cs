using System;

namespace _03.SumNumers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 0;

            while (sum < number)
            {
                var input = int.Parse(Console.ReadLine());

                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
