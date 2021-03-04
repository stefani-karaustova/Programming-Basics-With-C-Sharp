using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rightSum = 0;
            var leftSum = 0;

            for (int i = 0; i < n * 2; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
