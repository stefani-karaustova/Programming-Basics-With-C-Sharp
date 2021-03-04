using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                var priceOfTrip = double.Parse(Console.ReadLine());

                var savedMoney = 0.0;

                while (savedMoney < priceOfTrip)
                {
                    var inputMoney = double.Parse(Console.ReadLine());

                    savedMoney += inputMoney;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
