using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var vacationPrice = double.Parse(Console.ReadLine());
            var currentMoney = double.Parse(Console.ReadLine());

            var days = 0;
            var daysSpend = 0;

            while (currentMoney < vacationPrice)
            {
                days++;
                var input = Console.ReadLine();
                var money = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    daysSpend++;
                    if (daysSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                    currentMoney -= money;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                }

                else if (input == "save")
                {
                    daysSpend = 0;
                    currentMoney += money;
                }

                if (currentMoney >= vacationPrice)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                }
            }
        }
    }
}
