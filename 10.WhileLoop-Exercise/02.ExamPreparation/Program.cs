using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var limit = int.Parse(Console.ReadLine());

            var task = Console.ReadLine();

            var poorGrades = 0;
            var gradeCount = 0;
            var score = 0;
            var lastProblem = "";
            bool isPerfect = true;

            while (task != "Enough")
            {
                lastProblem = task;
                var grade = int.Parse(Console.ReadLine());
                gradeCount++;
                score += grade;

                if (grade <= 4)
                {
                    poorGrades++;
                    if (poorGrades >= limit)
                    {
                        isPerfect = false;
                        break;
                    }
                }
                task = Console.ReadLine();
            }

            var average = 1.0 * score / gradeCount;

            if (isPerfect)
            {
                Console.WriteLine($"Äverage score: {average:f2}");
                Console.WriteLine($"Number of problems: {gradeCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
        }
    }
}
