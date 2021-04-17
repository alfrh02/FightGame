using static FightGame.Store;

namespace FightGame
{
    public static class Strings
    {
        public static string choice1_1 = "";
        public static string choice1_2 = "";

        public static string choice2_1 = "";
        public static string choice2_2 = "";

        public static int choice = 0;

        //

        public static string O0B1 = "";
        public static string O0B2 = "";

        public static string O1B1 = "";
        public static string O1B2 = "";

        public static string O2B1 = "";
        public static string O2B2 = "";

        public static string O3B1 = "";
        public static string O3B2 = "";

        public static string STB1 = "";
        public static string STB2 = "";

        //

        public static string L1A = "";
        public static string L1A2 = "";

        public static string L2A = "";
        public static string L2A2 = "";

        public static string L3A = "";
        public static string L3A2 = "";

        public static string L4A = "";
        public static string L4A2 = "";

        //

        public static bool keepLooping = true;

        public static int CharacterChoose = 0;

        public static void CharacterChooser()
        {
            if (CharacterChoose == 5)
            {
                CharacterChoose = 0;
            }
            else if (CharacterChoose == -1)
            {
                CharacterChoose = 4;
            }
        }

        public static void StoreChooser()
        {
            if (StoreChoose == 4)
            {
                StoreChoose = 0;
            }
            else if (StoreChoose == -1)
            {
                StoreChoose = 3;
            }
        }

        public static void Choice()
        {
            if (choice == -1)
            {
                choice = 0;
            }
            if (choice == 2)
            {
                choice = 1;
            }
        }
    }
}
