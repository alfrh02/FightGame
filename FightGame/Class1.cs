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

        public static bool keepLooping = true;

        public static int CharacterChoose = 0;

        public static void CharacterChooser()
        {
            if (CharacterChoose == 3)
            {
                CharacterChoose--;
            }
            else if (CharacterChoose == -1)
            {
                CharacterChoose++;
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
