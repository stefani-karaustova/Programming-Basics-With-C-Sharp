using System;

namespace _04.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 1;

            while (sum <= number)
            {
                Console.WriteLine(sum);

                sum = sum * 2 + 1;
            }
        }
    }
}
