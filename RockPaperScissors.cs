using System;

namespace problems
{
    class RockPaperScissors
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors !");
            Console.WriteLine("1.Rock 2.Paper 3.Scissors 4.Exit");
            Console.Write("User 1 = ");
            int user1 = int.Parse(Console.ReadLine());
            Console.Write("User 2 = ");
            int user2 = int.Parse(Console.ReadLine());
            
            if (user1 == user2)
            {
                Console.WriteLine("You guys have choosen same options ! Retry Retry Retry");
                Main();
            }
            else
            {
                if ((user1 == 3 && user2 == 2) || (user1 == 2 && user2 == 1) || (user1 == 1 && user2 == 3))
                {
                    Console.WriteLine("User 1 wins !");
                }
                else if ((user1 == 1 && user2 == 2) || (user1 == 2 && user2 == 3) || (user1 == 3 && user2 == 1))
                { 
                    Console.WriteLine("User 2 wins !");
                }
                else
                {
                    Console.WriteLine("Invalid inputs");
                }

            }

        }
    }
}
