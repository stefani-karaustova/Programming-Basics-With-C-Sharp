using System;

namespace _07.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var sideOfSquare = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideOfSquare * sideOfSquare:F3}");
            }

            else if (figure == "rectangle")
            {
                var sideAOfRectangle = double.Parse(Console.ReadLine());
                var sideBOfRectangle = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideAOfRectangle * sideBOfRectangle:F3}");
            }
            else if (figure == "circle")
            {
                var radiusOfCircle = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radiusOfCircle * radiusOfCircle:F3}");
            }
            else if (figure == "triangle")
            {
                var sideOfTriangle = double.Parse(Console.ReadLine());
                var hOfTriangle = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideOfTriangle * hOfTriangle / 2:F3}");
            }
        }
    }
}
