using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());

            var pieces = length * width;

            while (true)
            {
                var input = Console.ReadLine();

                if (pieces <= 0 || input == "STOP")
                {
                    break;
                }

                var cake = int.Parse(input);

                pieces -= cake;
            }

            if (pieces >= 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
        }
    }
}
