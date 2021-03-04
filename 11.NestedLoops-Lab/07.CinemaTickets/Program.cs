using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalStandardTickets = 0;
            var totalStudentTickets = 0;
            var totalKidsTickets = 0;

            while (true)
            {
                var movie = Console.ReadLine();

                if (movie == "Finish")
                {
                    break;
                }

                var seats = int.Parse(Console.ReadLine());

                var availableTickets = 0;
                var totalFreeSeats = seats;

                while (seats > 0)
                {
                    var ticket = Console.ReadLine();

                    if (ticket == "End")
                    {
                        break;
                    }

                    switch (ticket)
                    {
                        case "standard":
                            totalStandardTickets++;
                            break;
                        case "kid":
                            totalKidsTickets++;
                            break;
                        case "student":
                            totalStudentTickets++;
                            break;
                    }

                    availableTickets++;
                    seats--;
                }

                var capacity = availableTickets * 1.0 / totalFreeSeats * 100;
                Console.WriteLine($"{movie} - {capacity:f2}% full.");
            }

            var totalTickets = totalStudentTickets + totalStandardTickets + totalKidsTickets;

            var studentTicketsInPercent = totalStudentTickets * 1.0 / totalTickets * 100;
            var kidsTicketsInPercent = totalKidsTickets * 1.0 / totalTickets * 100;
            var standardTicketsInPercent = totalStandardTickets * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");

            Console.WriteLine($"{studentTicketsInPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsInPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsInPercent:f2}% kids tickets.");
        }
    }
}
