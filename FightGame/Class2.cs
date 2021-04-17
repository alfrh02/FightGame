using System;
using System.Threading;
using static FightGame.Strings;
using static FightGame.Program;

namespace FightGame
{
    class Store
    {
        public static int playerArmour = 0;
        public static int armourBarCounter = playerArmour / 2;
        public static int playerArmourLimit;
        public static int enemyArmourLimit;
        public static int currency = 0;
        public static int StoreChoose = 0;
        public static bool playerBoughtArmour = false;

        public static void Buy()
        {
            StoreText();

            bool keepLooping = true;
            while (keepLooping)
            {
                if (StoreChoose == 0)
                {
                    L1A = "[";
                    L1A2 = "]";
                    Console.Clear();
                    StoreText();
                }
                else
                {
                    L1A = "";
                    L1A2 = "";
                    Console.Clear();
                    StoreText();
                }
                if (StoreChoose == 1)
                {
                    L2A = "[";
                    L2A2 = "]";
                    Console.Clear();
                    StoreText();
                }
                else
                {
                    L2A = "";
                    L2A2 = "";
                    Console.Clear();
                    StoreText();
                }
                if (StoreChoose == 2)
                {
                    L3A = "[";
                    L3A2 = "]";
                    Console.Clear();
                    StoreText();
                }
                else
                {
                    L3A = "";
                    L3A2 = "";
                    Console.Clear();
                    StoreText();
                }
                if (StoreChoose == 3)
                {
                    STB1 = "[";
                    STB2 = "]";
                    Console.Clear();
                    StoreText();
                }
                else
                {
                    STB1 = "";
                    STB2 = "";
                    Console.Clear();
                    StoreText();
                }

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    StoreChoose--;
                    Console.Clear();
                    StoreChooser();
                    StoreText();
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    StoreChoose++;
                    Console.Clear();
                    StoreChooser();
                    StoreText();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (StoreChoose)
                    {
                        case 0:
                            if (currency >= 5)
                            {
                                currency = -5;
                                playerArmour = 25;
                                playerBoughtArmour = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou cannot afford this item!");
                                Thread.Sleep(1500);
                                Console.Clear();
                                StoreText();
                            }
                            break;
                        case 1:
                            if (currency >= 10)
                            {
                                currency = -10;
                                playerArmour = 50;
                                playerBoughtArmour = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou cannot afford this item!");
                                Thread.Sleep(1500);
                                Console.Clear();
                                StoreText();
                            }
                            break;
                        case 2:
                            if (currency >= 15)
                            {
                                currency = -15;
                                playerArmour = 50;
                                playerBoughtArmour = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou cannot afford this item!");
                                Thread.Sleep(1500);
                                Console.Clear();
                                StoreText();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Main();
                            STB1 = "";
                            STB2 = "";
                            break;
                    }
                }
            }
        }
        public static void StoreText()
        {
            Console.WriteLine("Welcome to the Alf Arena Store.\n");
            Console.WriteLine($"  >  {L1A}25 AP{L1A2}");
            Console.WriteLine($"  >  {L2A}50 AP{L2A2}");
            Console.WriteLine($"  >  {L3A}100 AP{L3A2}\n");
            Console.WriteLine($"  >  {STB1}Main Menu{STB2}");
            if (playerBoughtArmour)
            {
                Console.WriteLine($"\nYou have bought {playerArmour} AP!");
            }
        }
    }
}
