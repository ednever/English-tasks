using System;
using System.IO;

namespace EpicBattle2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] heroes = { "Harry Potter", "Superman", "Luke Skywalker", "Lara Croft"};
            //string[] villains = { "Voldemort", "Joker", "Venom", "Dart Vader", "Cruella" };
            string folderPath = @"C:\Users\Kasutajad\opilane\Samples\";
            string[] heroes = GetDataFromFile(folderPath + "heroes.txt");
            string[] villains = GetDataFromFile(folderPath + "villains.txt");
            string[] heroWeapon = GetDataFromFile(folderPath + "heroWeapon.txt");
            string[] villainWeapon = GetDataFromFile(folderPath + "villainWeapon.txt");


            string randomHero = GetRandomElement(heroes);
            string randomVillain = GetRandomElement(villains);
            string heroWeapon = GetRandomElement(heroWeapon);
            string villainWeapon = GetRandomElement(villainWeapon);
            Console.WriteLine($"Your random hero is: {randomHero}");
            Console.WriteLine($"Your random villain is: {randomVillain}");
            Console.WriteLine($"{randomHero} with {heroWeapon} will fight {randomVillain} with {villainWeapon}");
        }

        public static string GetRandomElement(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;


        }

        public static string[] GetDataFromFile(string filePath)
        {
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    } 
}
