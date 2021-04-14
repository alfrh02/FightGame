using System;
using static FightGame.Strings;

namespace FightGame
{
    class Battle
    {
        public static void Fight()
        {
            Console.Clear();
            Console.WriteLine("Fight!");

            string[] Fighter = { "Rashiid", "Opponent 2", "Opponent 3" };

            if (O0B2 == "]")
            {
                CharacterChoose = 0;
            }
            else if (O1B2 == "]")
            {
                CharacterChoose = 1;
            }
            else if (O2B2 == "]")
            {
                CharacterChoose = 2;
            }

            Console.WriteLine(Fighter[CharacterChoose]);
        }
    }
}
