using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Superman", "Luke Skywalker", "Lara Croft"};
            string[] villains = { "Voldemort", "Joker", "Venom", "Dart Vader", "Cruella" };
            
            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            Console.WriteLine($"Your random hero is: {randomHero}");
            Console.WriteLine($"Your random villain is: {randomVillain}");
        }

        public static string GetRandomCharacter(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;
        }
    }
}
