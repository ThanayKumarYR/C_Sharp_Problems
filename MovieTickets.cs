using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class MovieTickets
    {
        public void pricing(int age)
        {
            Console.WriteLine("Calculating movie ticket price based the age you entered !");
            if (0 < age && age < 12)
            {
                Console.WriteLine("Based on your age, you come under Children catagery !");
                Console.WriteLine($"\nThe amount you have to pay Rupees 60 for each ticket\n");
            }
            else if (12 < age && age < 64)
            {
                Console.WriteLine("Based on your age, you come under adult catagery !");
                Console.WriteLine($"\nThe amount you have to pay Rupees 120 for each ticket\n");
            }
            else if (64 < age && age < 120)
            {
                Console.WriteLine("Based on your age, you come under senior citizen catagery !");
                Console.WriteLine($"\nThe amount you have to pay Rupees 90 for each ticket\n");
            }
            else
            {
                Console.WriteLine("You have entered the invalid age!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MovieTimes !");
            Console.WriteLine("The price of the movie tickets will charged based on your age !");
            Console.Write("Enter the your age = ");
            int age = int.Parse(Console.ReadLine());
            MovieTickets obj = new MovieTickets();
            obj.pricing(age);
            
        }
    }
}
