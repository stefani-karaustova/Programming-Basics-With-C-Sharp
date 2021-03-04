using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var maxNumber = int.MinValue;

            while (input != "Stop")
            {
                var number = int.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}
