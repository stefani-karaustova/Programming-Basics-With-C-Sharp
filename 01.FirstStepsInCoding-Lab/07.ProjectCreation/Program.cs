using System;

namespace _07.ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var numberOfProjects = int.Parse(Console.ReadLine());

            var hours = numberOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
