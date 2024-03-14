using System;

namespace problems
{ 
    class LoginSystem
    {
        public void login(string userName, string password)
        {
            foreach (var item in userName)
            {

                if (item == '!' || item == '@' || item == '#' || item == '%' || item == '^' || item == '&' || item == '*' || item == '(' || item == ')' || item == '-' || item == '+' || item == '=' || item == '{' || item == '}' || item == '[' || item == ']' || item == '\\' || item == '|' || item == ';' || item == ';' || item == ':' || item == '"' || item == '\'' || item == ',' || item == '.' || item == '/' || item == '<' || item == '>' || item == '?' || item == '`' || item == '~')
                {
                    Console.WriteLine("UserName cannot include special character");
                }
            }

            if (userName.Length < 3)
            {
                Console.WriteLine("The UserName should be more than 3 letters !");
            }
            else if (userName.Length > 12)
            {
                Console.WriteLine("The UserName cannot be more than 12 letters !");
            }
            else
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("The password should be more than 7 characters !");
                }
                else if (password.Length > 12)
                {
                    Console.WriteLine("The password cannot be more than 12 letters !");
                }
                else if (userName == "Thanay007" && password == "Thanay@123")
                {
                    Console.WriteLine($"Congratulations ! You have successfully logined to userName {userName}");
                }
                else if (userName == "Sujan010" && password == "Sujan@123")
                {
                    Console.WriteLine($"Congratulations ! You have successfully logined to userName {userName}");
                }
                else if (userName == "Arun011" && password == "Arun@123")
                {
                    Console.WriteLine($"Congratulations ! You have successfully logined to userName {userName}");
                }
                else
                {
                    Console.WriteLine("Invalid Credentails !");
                }
            }
        }
        static void Main(string[] args)
        {
            LoginSystem ls = new LoginSystem();
            Console.Write("Enter the user name = ");
            string userName = Console.ReadLine();
            userName = userName.Trim();
            Console.Write("Enter the password = ");
            string password = Console.ReadLine();
            password = password.Trim();
            ls.login(userName, password);
        }
    }
}
