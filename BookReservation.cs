using System;

namespace problems
{
    class BookReservation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Book Reservation !");
            Console.Write("Enter the book availability = ");
            int avail = int.Parse(Console.ReadLine());
            Console.Write("Enter the user limit = ");
            int limit = int.Parse(Console.ReadLine());
            Console.Write("Enter the Reservation Duration = ");
            int duration = int.Parse(Console.ReadLine());

            if (avail < limit)
            { 
                Console.WriteLine("Books availability is not there for the entered user limits");
            }
            else if (duration>15)
            {
                Console.WriteLine("Duration of the reservation cannot be more than 15 days !");
            }
            else
            {
                Console.WriteLine($"You can have {limit} books for {duration} days from now on !");
            }


        }
    }
}
