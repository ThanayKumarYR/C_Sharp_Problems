using System;

namespace problems
{
    class calculator
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator that takes two numbers only!");
            
            try 
            {
                Console.Write("Enter the first number = ");
                int firstNum = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number = ");
                int SecondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
                Console.Write("Enter your choice = ");
                int choice = int.Parse(Console.ReadLine());
                int res = 0;
                switch (choice) 
                {
                    case 1:
                        res = firstNum + SecondNum;
                        break;
                    case 2:
                        res = firstNum - SecondNum;
                        break;
                    case 3:
                        res = firstNum * SecondNum;
                        break;
                    case 4:
                        res = firstNum / SecondNum;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please choose between 1 to 4.");
                        break;
                }

                Console.WriteLine($"Result = {res}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }

        }
    }
}
