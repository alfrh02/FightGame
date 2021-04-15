using System;
using System.Threading;
using static FightGame.Strings;
using static FightGame.Program;

namespace FightGame
{
    class Battle
    {
        public static int playerHealth = 100;
        public static int playerHealthCounter = playerHealth / 2;
        public static string healthBar = "";
        public static bool playersTurn = true;
        public static bool playerDefending = false;
        public static bool enemyDefending = false;

        public static int enemyHealth = 100;
        public static string[] Fighter = { "Rashiid", "Jean-Michel", "Herman" };

        public static void Start()
        {
            FightText();
            bool keepLooping2 = true;
            while (keepLooping2)
            {
                if (playersTurn)
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
                        playersTurn = false;
                        Fight();
                    }
                }
                else
                {
                    enemyFight();
                }
            }
        }
        public static void FightText()
        {
            Console.WriteLine("Fight!");
            Console.WriteLine($"You're fighting... {Fighter[CharacterChoose]}!\n");
            Console.WriteLine($"{choice1_1}Attack{choice1_2} {choice2_1}Defend{choice2_2}\n");
            Console.Write($"HP : {playerHealth} ");
            healthBar = "";
            playerHealthCounter = playerHealth / 2;
            for (int i = 0; i <= playerHealthCounter; i++)
            {
                healthBar += "█";
            }
            Console.Write($"{healthBar}\n");
        }
        public static void Fight()
        {
            var rand = new Random();
            int damage = rand.Next(20,61);

            if (choice == 0)
            {
                if (enemyDefending == false)
                {
                    enemyHealth = enemyHealth - damage;
                    Console.WriteLine($"You punch {Fighter[CharacterChoose]}, he's now on {enemyHealth} HP.");
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("You win!");
                        enemyHealth = 100;
                        playerHealth = 100;
                        Thread.Sleep(500);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        Start();
                    }
                }
                else
                {
                    Console.WriteLine($"You throw a punch but {Fighter[CharacterChoose]}'s defense is too strong.");
                    enemyDefending = false;
                    Thread.Sleep(500);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Start();
                }
            }
            else if (choice == 1)
            {
                Console.WriteLine($"You defend yourself from any incoming attacks.");
                playerDefending = true;
                Thread.Sleep(500);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Start();
            }
        }
        public static void enemyFight()
        {
            var rand = new Random();
            int damage = rand.Next(20, 61);
            int chance = rand.Next(0,100);

            if (chance > 74)
            {
                chance = 1; //defending
            }
            else if (chance < 75)
            {
                chance = 0; //attacking
            }
            if (chance == 0) //attack
            {
                if (playerDefending == false)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{Fighter[CharacterChoose]} punches you for {damage} damage!");
                    playerHealth = playerHealth - damage;
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("You lose!");
                        enemyHealth = 100;
                        playerHealth = 100;
                        Thread.Sleep(1000);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        playersTurn = true;
                        Thread.Sleep(500);
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        Start();
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{Fighter[CharacterChoose]} attempts to damage you, but your defense is too strong.");
                    playerDefending = false;
                    playersTurn = true;
                    Thread.Sleep(500);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Start();
                }
            }
            else if (chance == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Fighter[CharacterChoose]} defends himself");
                enemyDefending = true;
                playersTurn = true;
                Thread.Sleep(500);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Start();
            }
        }
    }
}
