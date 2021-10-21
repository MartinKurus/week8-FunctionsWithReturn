using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain, weapon;
            string heroWeapon, villainWeapon;
            hero = RandomHero();
            villain = RandomVillain();
            heroWeapon = RandomWeapon();
            villainWeapon = RandomWeapon();
            Console.WriteLine($"Random hero {hero} with random weapon {heroWeapon} fights vs random villain {villain} with random weapon {villainWeapon}");
            

        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);

            return RandomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Lara Croft" };
            return heroes[RandomIndex(heroes)];
        }

        private static string RandomVillain()
        {
            string[] villains = { "Thanos", "Joker", "Darth Vader" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, villains.Length);
            string randomVillain = villains[RandomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "Wooden sword", "Diamond sword", "Iron sword"};
            return weapon[RandomIndex(weapon)];
        }
    }
}
