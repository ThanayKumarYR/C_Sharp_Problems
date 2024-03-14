using System;

namespace problems
{
    class AirQuality
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Air Quality Control");
            Console.WriteLine("Enter the AQI value and know AQI level !");
            Console.Write("Enter the value = ");
            int value = int.Parse(Console.ReadLine());
            if (0 <= value && value <= 50)
            {
                Console.WriteLine($"AQI value {value} is on 'GOOD' level in AQI!");
            }
            else if (51 <= value && value <= 100)
            {
                Console.WriteLine($"AQI value {value} is on 'MODERATE' level in AQI!");
            }
            else if (101 <= value && value <= 150)
            {
                Console.WriteLine($"AQI value {value} is on 'UNHEALTHY' level in AQI!");
            }
            else if (151 <= value && value <= 200)
            {
                Console.WriteLine($"AQI value {value} is on 'VERY UNHEALTHY' level in AQI!");

            }
            else if (value > 200)
            {
                Console.WriteLine($"AQI value {value} is on 'HAZARDOUS' level in AQI!");
            }
            else 
            {
                Console.WriteLine("Invalid Input !");
            }
        }
    }
}
