using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var n = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];

                switch (currentLetter)
                {
                    case 'a':
                        n += 1;
                        break;
                    case 'e':
                        n += 2;
                        break;
                    case 'i':
                        n += 3;
                        break;
                    case 'o':
                        n += 4;
                        break;
                    case 'u':
                        n += 5;
                        break;
                }
            }

            Console.WriteLine(n);
        }
    }
}
