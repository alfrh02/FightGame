namespace FightGame
{
    public static class Strings
    {
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
    }
}
