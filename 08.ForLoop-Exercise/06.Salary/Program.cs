using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var openedTabs = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < openedTabs; i++)
            {
                var tab = Console.ReadLine();

                if (tab == "Facebook")
                {
                    salary -= 150;
                }
                else if (tab == "Instagram")
                {
                    salary -= 100;
                }
                else if (tab == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
