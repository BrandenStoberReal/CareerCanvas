using System.Globalization;
using CareerCanvas.Classes.Configs;

namespace CareerCanvas.Classes.Static;

public static class Globals
{
    /// <summary>
    ///     The text info object for the application.
    /// </summary>
    public static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

    /// <summary>
    ///     Global identity service config.
    /// </summary>
    public static IdentityConfig IdentityConfig { get; set; } = new();

    /// <summary>
    ///     Global application config.
    /// </summary>
    public static AppConfig AppConfig { get; set; } = new();

    /// <summary>
    ///     The path to the identity config file.
    /// </summary>
    public static string IdentityConfigPath { get; set; } = "./data/misc/identity.careerconfig";
}