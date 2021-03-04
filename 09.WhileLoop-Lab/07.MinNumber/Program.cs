using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var minNumber = int.MaxValue;

            while (input != "Stop")
            {
                var number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
