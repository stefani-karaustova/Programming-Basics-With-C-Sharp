using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchedBook = Console.ReadLine();

            var nameOfBook = Console.ReadLine();

            var count = 0;

            while (nameOfBook != "No More Books")
            {
                if (nameOfBook == searchedBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    Environment.Exit(0);
                }

                nameOfBook = Console.ReadLine();

                count++;
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");
        }
    }
}
