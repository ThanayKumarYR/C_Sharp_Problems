using System;

namespace problems
{
    class TraficLights
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to trafic signal !");
            Random rad = new Random();
            if (rad.Next(1, 4) == 1)
            { 
                Console.WriteLine("It is 'RED', please stop !");
            }
            else if (rad.Next(1, 4) == 2)
            {
                Console.WriteLine("It is 'YELLOW', please 'GET READY' !");

            }
            else if (rad.Next(1, 4) == 3)
            {
                Console.WriteLine("It is 'GREEN', You can 'GO' !");
            }
        }
    }
}
