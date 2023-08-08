using TravelApp.Debugging;

namespace TravelApp
{
    public class TravelAppConsts
    {
        public const string LocalizationSourceName = "TravelApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ebeaca56d2204d7da6d542741a135f1d";
    }
}
