using System;

namespace _07.SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var timeForMeter = double.Parse(Console.ReadLine());

            var timeSwimming = distance * timeForMeter;
            var waterResist = Math.Floor(distance / 15);
            var timeAdded = waterResist * 12.5;
            var totalTime = timeSwimming + timeAdded;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else if (totalTime >= record)
            {
                double secondsSlower = totalTime - record;
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}
