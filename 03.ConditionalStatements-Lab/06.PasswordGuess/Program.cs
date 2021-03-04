using System;

namespace _06.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var rightPassword = "s3cr3t!P@ssw0rd";

            if (password == rightPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
