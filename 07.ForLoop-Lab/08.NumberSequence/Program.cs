using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var maxNumber = int.MinValue;
            var minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber > maxNumber)
                {
                    maxNumber = inputNumber;
                }

                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
