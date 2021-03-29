namespace MCDSaveEdit
{
    public static class Secrets
    {
        // Fill in the value for this one
        public static string[] PAKS_AES_KEY_STRINGS = new string[] {
            //"",
        };
        
        public static void SetAesKey(string newKey)
        {
            PAKS_AES_KEY_STRINGS = new string[] { newKey };
        }

        // You can leave these empty, they just need to exist
        public const string GAME_ANALYTICS_GAME_KEY = "";
        public const string GAME_ANALYTICS_SECRET_KEY = "";
    }
}