using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPages = int.Parse(Console.ReadLine());
            var pagesPerHour = double.Parse(Console.ReadLine());
            var numberOfDays = int.Parse(Console.ReadLine());

            var totalTimeForBook = totalPages / pagesPerHour;
            var totalTimePerDay = totalTimeForBook / numberOfDays;

            Console.WriteLine(totalTimePerDay);
        }
    }
}
