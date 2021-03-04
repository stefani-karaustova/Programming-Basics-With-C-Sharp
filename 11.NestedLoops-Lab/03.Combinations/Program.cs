﻿using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var steps = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        if (i + j + k == n)
                        {
                            steps++;
                        }
                    }
                }
            }

            Console.WriteLine(steps);
        }
    }
}
