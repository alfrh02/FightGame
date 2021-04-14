using System;
using static FightGame.Strings;
using static FightGame.Battle;

namespace FightGame
{
    class Program
    {
        public static void Main(string[] args)
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
                    keepLooping = false;
                    Fight();
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to ALFRED'S ARENA!\n\nChoose your opponent.\n");
            Console.WriteLine($"{O0B1}Rashiid{O0B2}"); //0
            Console.WriteLine($"{O1B1}Opponent 2{O1B2}"); //1
            Console.WriteLine($"{O2B1}Opponent 3{O2B2}\n"); //2
            Console.WriteLine("Press the arrow keys to choose your opponent.");
            Console.WriteLine(CharacterChoose);
        }
    }
}
