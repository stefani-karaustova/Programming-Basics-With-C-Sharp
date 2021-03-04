using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var savedMoney = 0.0;

            while (input != "NoMoreMoney")
            {
                var money = double.Parse(input);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                savedMoney += money;
                Console.WriteLine($"Increase: {money:f2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {savedMoney:f2}");
        }
    }
}
