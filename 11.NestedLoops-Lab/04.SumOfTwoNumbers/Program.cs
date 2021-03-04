using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());

            var steps = 0;
            bool flag = false;

            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    steps++;

                    var sum = i + j;

                    if (sum == number)
                    {
                        Console.WriteLine($"Combination N:{steps} ({i} + {j} = {sum})");
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{steps} combinations - neither equals {number}");
            }
        }
    }
}
