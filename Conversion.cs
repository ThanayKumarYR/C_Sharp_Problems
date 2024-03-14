using System;

namespace problems
{
    class Conversion
    {
        public void FarToCel(double temp)
        {
            try
            {
                double Celsius = (temp - 32.0) * (5.0 / 9.0);
                Console.WriteLine($"{temp} Fahrenheit = {Celsius} Celsius");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception = {e}");
            }
            finally { Console.WriteLine("Thank You !"); }

        }
        public void CelToFar(double temp)
        {
            try
            {
                double Fahrenheit = (temp * 9.0 / 5.0) + 32.0;
                Console.WriteLine($"{temp} Celsius = {Fahrenheit} Fahrenheit");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception = {e}");
            }
            finally { Console.WriteLine("Thank You !"); }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to temperature Conversion!");
            Console.WriteLine("To convert from Fahrenheit to Celsius press 1");
            Console.WriteLine("To convert from Celsius to Fahrenheit press 2");
            Console.Write("Enter 1 or 2 : ");
            int choice = int.Parse(Console.ReadLine());

            Conversion obg = new Conversion();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Converting Fahrenheit to Celsius");
                    Console.Write("Enter the value = ");
                    double temp = double.Parse(Console.ReadLine());
                    obg.FarToCel(temp);
                    break;
                case 2:
                    Console.WriteLine("Converting Celsius to Fahrenheit");
                    Console.Write("Enter the value = ");
                    double temp1 = double.Parse(Console.ReadLine());
                    obg.CelToFar(temp1);

                    break;
                default:
                    Console.WriteLine("You have entered the wrong choice !");
                    break;
            }

        }
    }
}
