using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            var totalSteps = 0;

            while (totalSteps < goal)
            {
                var input = Console.ReadLine();

                if (input == "Going home")
                {
                    var stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }
                else
                {
                    var steps = int.Parse(input);
                    totalSteps += steps;
                }
            }

            if (totalSteps >= goal)
            {
                var stepsOver = totalSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                var stepsMore = goal - totalSteps;
                Console.WriteLine($"{stepsMore} more steps to reach goal.");
            }
        }
    }
}
