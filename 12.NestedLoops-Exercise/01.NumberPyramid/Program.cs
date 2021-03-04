using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var row = 1;
            var currentNumber = 1;
            bool isEqual = false;

            while (isEqual == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                    if (currentNumber > number)
                    {
                        isEqual = true;
                        break;
                    }
                }

                Console.WriteLine();
                row++;
            }
        }
    }
}
