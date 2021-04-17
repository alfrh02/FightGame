using System;
using static FightGame.Strings;
using static FightGame.Battle;
using static FightGame.Store;

namespace FightGame
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
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to the Alf Arena.\n\nChoose your opponent.\n");
            Console.WriteLine($"  >  {O0B1}Herman{O0B2}"); //0
            Console.WriteLine($"  >  {O1B1}Jean-Michel{O1B2}"); //1
            Console.WriteLine($"  >  {O2B1}Joëlle{O2B2}"); //2
            Console.WriteLine($"  >  {O3B1}Rashiid{O3B2}\n"); //3
            Console.WriteLine("Press the arrow keys to choose your opponent. Alternatively, visit the...\n");
            Console.WriteLine($"  >  {STB1}Store{STB2}\n"); //4
            Console.WriteLine($"You have {currency} coins.");
            Console.WriteLine(CharacterChoose);
        }
    }
}
