using System;
using System.Threading;
using static FightGame.Strings;
using static FightGame.Program;
using static FightGame.Store;

namespace FightGame
{
    class Battle
    {
        public static int playerHealth = 100;
        public static int playerHealthCounter = playerHealth / 2;

        public static string healthBar = "";
        public static string armourBar = "";

        public static bool playersTurn = true;
        public static bool playerDefending = false;
        public static bool enemyDefending = false;

        public static int enemyHealth = 100;
        public static int enemyArmour = 0;

        public static bool female = false;

        public static string[] Fighter = { "Herman", "Jean-Michel", "Joëlle", "Rashiid" };

        public static bool initHappened = false;

        public static void WinCheck()
        {
            if (enemyHealth <= 0)
            {
                Console.WriteLine("You win!");
                switch (CharacterChoose)
                {
                    case 0:
                        currency = +5;
                        break;
                    case 1:
                        currency = +10;
                        break;
                    case 2:
                        currency = +15;
                        break;
                    case 3:
                        currency = +1000000;
                        break;
                }
                enemyHealth = 100;
                playerHealth = 100;
                Thread.Sleep(500);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        public static void Init()
        {
                      
            switch (CharacterChoose)
            {
                case 0:
                    enemyArmour = 0;
                    break;
                case 1:
                    enemyArmour = 25;
                    break;
                case 2:
                    enemyArmour = 50;
                    break;
                case 3:
                    enemyArmour = 100;
                    break;
            }
            playerArmourLimit = playerArmour;
            enemyArmourLimit = enemyArmour;
            initHappened = true;
        }

        public static void Start()
        {
            if (initHappened == false)
            {
                Init();
            }
            WinCheck();

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
            Console.WriteLine($"{Fighter[CharacterChoose]} has {enemyHealth} HP and {enemyArmour} AP.\n");
            Console.WriteLine($"HP : {playerHealth}");
            healthBar = "";
            armourBar = "";
            playerHealthCounter = playerHealth / 2;
            for (int i = 0; i <= playerHealthCounter; i++)
            {
                healthBar += "█";
            }
            Console.WriteLine($"{healthBar}");
            armourBarCounter = playerArmour / 2;
            if (playerArmour > 0)
            {
                for (int a = 0; a <= armourBarCounter; a++)
                {
                    armourBar += "|";
                }
                Console.WriteLine($"AP : {playerArmour}");
                Console.WriteLine($"{armourBar}");
            }
        }
        public static void Fight()
        {
            Random rand = new Random();
            int damage = rand.Next(20,41);

            if (CharacterChoose == 2)
            {
                female = true;
            }

            if (choice == 0)
            {
                if (enemyDefending == false)
                {
                    if (enemyArmour == 0)
                    {
                        enemyHealth = enemyHealth - damage;
                        if (female)
                        {
                            Console.WriteLine($"You punch {Fighter[CharacterChoose]}, she's now on {enemyHealth} HP.");
                        }
                        else
                        {
                            Console.WriteLine($"You punch {Fighter[CharacterChoose]}, he's now on {enemyHealth} HP.");
                        }
                        if (enemyHealth <= 0)
                        {
                            Console.WriteLine("You win!");
                            switch (CharacterChoose)
                            {
                                case 0:
                                    currency = +5;
                                    break;
                                case 1:
                                    currency = +10;
                                    break;
                                case 2:
                                    currency = +15;
                                    break;
                                case 3:
                                    currency = +1000000;
                                    break;
                            }
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
                        enemyArmour = enemyArmour - damage;

                        if (female)
                        {
                            Console.WriteLine($"You punch {Fighter[CharacterChoose]} for {damage}, her armour absorbs the damage.");
                        }
                        else
                        {
                            Console.WriteLine($"You punch {Fighter[CharacterChoose]} for {damage}, his armour absorbs the damage.");
                        }
                        if (enemyArmour < 0)
                        {
                            enemyArmour = 0;    
                            Console.WriteLine($"You broke {Fighter[CharacterChoose]}'s armour.");
                            Thread.Sleep(500);
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            Start();
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
                if (playerArmour > 0)
                {
                    int addedPlayerArmour = 20;
                    int shavedOffPlayerArmour = 0;
                    playerArmour = playerArmour + addedPlayerArmour;
                    if (playerArmour > enemyArmourLimit)
                    {
                        shavedOffPlayerArmour = enemyArmour - enemyArmourLimit;
                    }
                    enemyArmour = playerArmour - shavedOffPlayerArmour;
                    addedPlayerArmour = addedPlayerArmour - shavedOffPlayerArmour;
                    Console.WriteLine($"You gain {addedPlayerArmour} AP.");
                }
                else
                {
                    Console.WriteLine($"You defend yourself.");
                    playerDefending = true;
                }
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
            int damage = rand.Next(20, 41);
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
                    Thread.Sleep(500);
                    if (playerArmour == 0)
                    {
                        Console.WriteLine($"{Fighter[CharacterChoose]} punches you for {damage}.");
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
                        playerArmour = playerArmour - damage;
                        Console.WriteLine($"{Fighter[CharacterChoose]} punches you for {damage}, your armour absorbs the damage.");
                        if (playerArmour < 0)
                        {
                            playerArmour = 0;
                            Console.WriteLine($"{Fighter[CharacterChoose]} broke your armour.");
                            Thread.Sleep(500);
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            Start();
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
                }
                else
                {
                    Thread.Sleep(500);
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
                Thread.Sleep(500);
                if (enemyArmour > 0)
                {
                    int addedEnemyArmour = 20;
                    int shavedOffArmour = 0;
                    enemyArmour = enemyArmour + addedEnemyArmour;
                    if (enemyArmour > enemyArmourLimit)
                    {
                        shavedOffArmour = enemyArmour - enemyArmourLimit;
                    }
                    enemyArmour = enemyArmour - shavedOffArmour;
                    addedEnemyArmour = addedEnemyArmour - shavedOffArmour;
                    Console.WriteLine($"{Fighter[CharacterChoose]} gains {addedEnemyArmour} AP.");
                }
                else
                {
                    enemyDefending = true;
                    Console.WriteLine($"{Fighter[CharacterChoose]} defends themselves.");
                }
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
