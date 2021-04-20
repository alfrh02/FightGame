using System;
using System.Threading;
using static Alfight.Strings;
using static Alfight.Battle;
using static Alfight.Store;

namespace Alfight
{
    class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;
            O0B1 = "[";
            O0B2 = "]";
            Menu();

            CharacterChoose = 0;

            bool keepLooping = true;
            while (keepLooping)
            {
                if (CharacterChoose == 0)
                {
                    O0B1 = "[";
                    O0B2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    O0B1 = "";
                    O0B2 = "";
                    Console.Clear();
                    Menu();
                }
                if (CharacterChoose == 1)
                {
                    O1B1 = "[";
                    O1B2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    O1B1 = "";
                    O1B2 = "";
                    Console.Clear();
                    Menu();
                }
                if (CharacterChoose == 2)
                {
                    O2B1 = "[";
                    O2B2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    O2B1 = "";
                    O2B2 = "";
                    Console.Clear();
                    Menu();
                }
                if (CharacterChoose == 3)
                {
                    O3B1 = "[";
                    O3B2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    O3B1 = "";
                    O3B2 = "";
                    Console.Clear();
                    Menu();
                }
                if (CharacterChoose == 4)
                {
                    STB1 = "[";
                    STB2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    STB1 = "";
                    STB2 = "";
                    Console.Clear();
                    Menu();
                }
                if (CharacterChoose == 5)
                {
                    HB1 = "[";
                    HB2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    HB1 = "";
                    HB2 = "";
                    Console.Clear();
                    Menu();
                }
                if(CharacterChoose == 6)
                {
                    QB1 = "[";
                    QB2 = "]";
                    Console.Clear();
                    Menu();
                }
                else
                {
                    QB1 = "";
                    QB2 = "";
                    Console.Clear();
                    Menu();
                }

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    CharacterChoose--;
                    Console.Clear();
                    CharacterChooser();
                    Menu();
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    CharacterChoose++;
                    Console.Clear();
                    CharacterChooser();
                    Menu();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (CharacterChoose == 0 || CharacterChoose == 1 || CharacterChoose == 2 || CharacterChoose == 3)
                    {
                        Console.Clear();
                        Start();
                    }
                    else if (CharacterChoose == 4)
                    {
                        Console.Clear();
                        Buy();
                    }
                    else if (CharacterChoose == 5)
                    {
                        Console.Clear();
                        Help();
                    }
                    else if (CharacterChoose == 6)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to the Alf Arena.\n\nChoose your opponent.\n");
            Console.Write("  >  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{O0B1}Herman{O0B2}\n"); //0
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  >  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{O1B1}Jean-Michel{O1B2}\n"); //1
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  >  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{O2B1}Joëlle{O2B2}\n"); //2
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  >  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{O3B1}Rashiid{O3B2}\n\n"); //3
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press the arrow keys to choose your opponent. Alternatively, visit the...\n");
            Console.Write($"  >  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{STB1}Store{STB2}\n\n"); //4
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You have ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{currency}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" coins.\n\n");
            Console.Write($"  >  ");
            Console.Write($"{HB1}Help{HB2}\n"); //5
            Console.Write($"  >  ");
            if (CharacterChoose == 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{QB1}Quit{QB2}\n"); //6
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(CharacterChoose); //debugging
        }
        public static void Help()
        {
            Console.WriteLine("The Alf Arena is a place which gets progressively harder as you battle each opponent.\n");
            Console.Write("Each opponent rewards you with a certain amount of coins you can use in exchange for ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AP (armour points)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" at the");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" store.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Each opponent has more AP than the last.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Herman ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("starts with 0.\n\n");
            Console.Write("Don't spam keys if you're on Windows. Windows Console sucks.\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
