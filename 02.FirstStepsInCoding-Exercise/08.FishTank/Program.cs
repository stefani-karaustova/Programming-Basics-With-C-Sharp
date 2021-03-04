using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var liter = 0.001;

            var totalVolume = length * width * height;
            var totalCapacity = totalVolume * liter;
            var percentOccupied = percent * 0.01;

            var totalLitersNeeded = totalCapacity * (1 - percentOccupied);

            Console.WriteLine(totalLitersNeeded);
        }
    }
}
