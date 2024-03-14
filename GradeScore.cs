using System;
namespace problems
{

    class Program
    {
        public void studendsScore()
        {
            Console.Write("Enter the score your secured = ");
            string strnum = Console.ReadLine();
            int score = int.Parse(strnum);

            if (90 <= score && score <= 100)
            {
                Console.WriteLine($"You have secured A grade with score {score}");
            }
            else if (90 <= score && score <= 100)
            {
                Console.WriteLine($"You have secured B grade with score {score}");
            }
            else if (80 <= score && score <= 89)
            {
                Console.WriteLine($"You have secured C grade with score {score}");
            }
            else if (70 <= score && score <= 79)
            {
                Console.WriteLine($"You have secured D grade with score {score}");
            }
            else if (60 <= score && score <= 69)
            {
                Console.WriteLine($"You have secured E grade with score {score}");
            }
            else if (0 <= score && score <= 59)
            {
                Console.WriteLine($"You have secured F grade with score {score}");
            }
            else
            {
                Console.WriteLine($"You have entered invalid score !");
            }
        }
        static void Main(string[] args)
        {
            Program obg = new Program();
            obg.studendsScore();
        }
    }
}
