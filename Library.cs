using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Library
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library !");
            Console.Write("Enter the number of days a book is overdue = ");
            int days = int.Parse(Console.ReadLine());

            if (days <= 7)
            {
                Console.WriteLine("Your Overdue is within the seven days, so no need to pay fine");
            }
            else if (days > 7)
            {
                float fine = days * 0.50f;
                Console.WriteLine($"You have to pay fine of ${fine}");
            }
            else
            { 
                Console.WriteLine("Invalid Input !");
            }
           
        }
    }
}
