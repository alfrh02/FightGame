using System;
using System.Threading;
using static FightGame.Strings;
using static FightGame.Program;

namespace FightGame
{
    class Battle
    {
        public static int playerHealth = 100;
        public static int enemyHealth = 100;
        public static string[] Fighter = { "Rashiid", "Jean-Michel", "Herman" };

        public static void Start()
        {
            bool keepLooping2 = true;
            while (keepLooping2)
            {
                if (choice == 0)
                {
                    choice1_1 = "[";
                    choice1_2 = "]";
                    Console.Clear();
                    FightText();
                }
                else
                {
                    choice1_1 = "";
                    choice1_2 = "";
                    Console.Clear();
                    FightText();
                }
                if (choice == 1)
                {
                    choice2_1 = "[";
                    choice2_2 = "]";
                    Console.Clear();
                    FightText();
                }
                else
                {
                    choice2_1 = "";
                    choice2_2 = "";
                    Console.Clear();
                    FightText();
                }
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    choice--;
                    Console.Clear();
                    Choice();
                    FightText();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    choice++;
                    Console.Clear();
                    Choice();
                    FightText();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    keepLooping2 = false;
                    Fight();
                }
            }
        }
        public static void FightText()
        {
            Console.WriteLine("Fight!");
            Console.WriteLine($"You're fighting... {Fighter[CharacterChoose]}!\n");
            Console.WriteLine($"{choice1_1}Attack{choice1_2} {choice2_1}Defend{choice2_2}");
        }
        public static void Fight()
        {
            var rand = new Random();

            int damage = rand.Next(20,61);

            if (choice == 0)
            {
                enemyHealth = enemyHealth - damage;
                Console.WriteLine($"You punch {Fighter[CharacterChoose]}, he's now on {enemyHealth} HP.");
                if (enemyHealth <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You win!");
                    enemyHealth = 100;
                    Thread.Sleep(1000);
                    Main();
                }
                else
                {
                    Thread.Sleep(2000);
                    Start();
                }
            }
            else if (choice == 1)
            {
                Console.WriteLine($"You defend yourself from any incoming attacks except the enemy cant attakc yet i havent added that yet lol");
                Thread.Sleep(2000);
                Start();
            }
            
        }
    }
}
