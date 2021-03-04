using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = double.Parse(Console.ReadLine());
            var depositDue = int.Parse(Console.ReadLine());
            var yearInterest = double.Parse(Console.ReadLine());

            var interestAmount = deposit * yearInterest / 100;
            var interestPerMonth = interestAmount / 12;
            var totalSum = deposit + depositDue * interestPerMonth;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
