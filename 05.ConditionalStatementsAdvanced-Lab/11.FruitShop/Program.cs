using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantiti = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" ||
                day == "Wednesday" || day == "Thursday" ||
                day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{2.5 * quantiti:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{1.2 * quantiti:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{0.85 * quantiti:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{1.45 * quantiti:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{2.7 * quantiti:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{5.5 * quantiti:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{3.85 * quantiti:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{2.7 * quantiti:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{1.25 * quantiti:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{0.9 * quantiti:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{1.6 * quantiti:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{3 * quantiti:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{5.6 * quantiti:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{4.2 * quantiti:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
