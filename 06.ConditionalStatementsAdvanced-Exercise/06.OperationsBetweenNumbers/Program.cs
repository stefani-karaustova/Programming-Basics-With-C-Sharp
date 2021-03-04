using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            var result = 0.0;

            if (operation == "+")
            {
                result = number1 + number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - odd");
                }
            }

            else if (operation == "-")
            {
                result = number1 - number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - odd");
                }
            }

            else if (operation == "*")
            {
                result = number1 * number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result} - odd");
                }
            }

            else if (operation == "/")
            {
                result = number1 / number2;
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result:f2}");
                }
            }

            else if (operation == "%")
            {
                result = number1 % number2;
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} {operation} {number2} = {result}");
                }
            }
        }
    }
}
