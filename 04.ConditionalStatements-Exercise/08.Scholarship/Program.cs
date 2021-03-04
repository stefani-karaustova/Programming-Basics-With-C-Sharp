using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var incomeBGN = double.Parse(Console.ReadLine());
            var averageGrade = double.Parse(Console.ReadLine());
            var minimalSalary = double.Parse(Console.ReadLine());

            var scholarshipForExcellentResult = Math.Floor(averageGrade * 25);
            var socialScholarship = Math.Floor(0.35 * minimalSalary);

            if (incomeBGN >= minimalSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResult} BGN");
            }
            else if (incomeBGN >= minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (incomeBGN < minimalSalary && averageGrade >= 5.5 && socialScholarship <= scholarshipForExcellentResult)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResult} BGN");
            }
            else if (incomeBGN < minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (incomeBGN < minimalSalary && averageGrade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
