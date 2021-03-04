using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var sum = 0.0;
            var currentGrade = 1;
            var repeatingClass = 0;

            while (currentGrade <= 12)
            {
                if (repeatingClass == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                    Environment.Exit(0);
                }

                var grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    repeatingClass++;
                    continue;
                }

                sum += grade;
                currentGrade++;
            }

            var averageGrade = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
