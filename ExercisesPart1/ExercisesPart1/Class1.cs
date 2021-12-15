using System;

namespace Login_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            //login: admin
            //password: pass1234

            //declare variables
            //assign value
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;
            Console.WriteLine("Enter your login: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            userPassword = Console.ReadLine();

            if (login == userName and password == userPassword)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Oops. Something went wrong.");
            }
        }
    }
}