using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var volume = width * length * height;

            var input = Console.ReadLine();

            while (input != "Done")
            {
                var boxes = int.Parse(input);

                volume -= boxes;

                if (volume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {volume * -1} Cubic meters more.");
                    Environment.Exit(0);
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
