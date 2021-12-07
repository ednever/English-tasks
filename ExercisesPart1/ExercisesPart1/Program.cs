using System;

namespace ExercisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userLastName;
            int userBirthday, age;
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            userLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName} {userLastName}");

            Console.WriteLine("Enter your year of birthday: ");
            userBirthday = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(DateTime.Now.Year.ToString());
            age = year - userBirthday;
            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagram");
            } else
            {
                Console.WriteLine("You are too Young to have Instagram account");
            }

            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
