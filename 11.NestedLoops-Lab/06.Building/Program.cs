using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            var floors = int.Parse(Console.ReadLine());
            var rooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{floors}{i} ");
            }

            Console.WriteLine();

            for (int currentFloor = floors - 1; currentFloor > 0; currentFloor--)
            {
                for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
                {
                    if (currentFloor % 2 == 0)
                    {
                        Console.Write($"O{currentFloor}{currentRoom} ");
                    }
                    else
                    {
                        Console.Write($"A{currentFloor}{currentRoom} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
