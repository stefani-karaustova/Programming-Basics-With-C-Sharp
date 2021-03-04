using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMeter = double.Parse(Console.ReadLine());

            var price = squareMeter * 7.61;
            var discount = price * 0.18;
            var finalPrice = price - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
