using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();
            var inputPass = Console.ReadLine();

            while (inputPass != password)
            {
                inputPass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
