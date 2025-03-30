using CareerCanvas.Classes.Configs;
using System.Globalization;

namespace CareerCanvas.Classes.Static
{
    public static class Globals
    {
        /// <summary>
        /// Global identity service config.
        /// </summary>
        public static IdentityConfig IdentityConfig { get; set; } = new IdentityConfig();

        /// <summary>
        /// Global application config.
        /// </summary>
        public static AppConfig AppConfig { get; set; } = new AppConfig();

        /// <summary>
        /// The text info object for the application.
        /// </summary>
        public static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        /// <summary>
        /// The path to the identity config file.
        /// </summary>
        public static string IdentityConfigPath { get; set; } = "./data/misc/identity.careerconfig";
    }
}