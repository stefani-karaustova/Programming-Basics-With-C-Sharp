using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var gradeCount = 0.0;
            var sumOfAllGrades = 0.0;

            while (input != "Finish")
            {
                var gradeSum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    var grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    gradeCount++;
                    sumOfAllGrades += grade;
                }

                var average = gradeSum / n;
                Console.WriteLine($"{input} - {average:f2}.");
                input = Console.ReadLine();
            }

            var averageOfAll = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averageOfAll:f2}.");
        }
    }
}
