﻿using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                price = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                price = 14;
            }
            else
            {
                price = 16;
            }

            Console.WriteLine(price);
        }
    }
}
