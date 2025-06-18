using CareerCanvas.Classes.Configs;
using CareerCanvas.Classes.Main.Protobuf;
using Serilog;
using System.Globalization;
using ILogger = Serilog.ILogger;

namespace CareerCanvas.Classes.Static;

public static class Globals
{
    /// <summary>
    /// Boolean for whether the application is running in debug mode.
    /// </summary>
    public static bool DebugMode =
#if DEBUG
    true;

#else
    false;
#endif

    /// <summary>
    ///    The logger for the application.
    /// </summary>
    public static ILogger AppLogger { get; private set; } = new LoggerConfiguration()
#if DEBUG
    .MinimumLevel.Debug()
    .WriteTo.File("logs/app-debug.log", rollingInterval: RollingInterval.Day)
#else
    .MinimumLevel.Information()
    .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
#endif
    .CreateLogger();

    /// <summary>
    ///     The text info object for the application.
    /// </summary>
    public static TextInfo CultureTextInfo = new CultureInfo("en-US", false).TextInfo;

    /// <summary>
    ///     Global identity service config.
    /// </summary>
    public static IdentityConfig IdentityConfig { get; set; } = new();

    /// <summary>
    ///     Global application config.
    /// </summary>
    public static AppConfig AppConfig { get; set; } = new();

    /// <summary>
    ///    AI keys and secrets.
    /// </summary>
    public static AiSecrets AiSecrets { get; set; } = new();

    /// <summary>
    /// User preferences
    /// </summary>
    public static Preferences Preferences { get; set; } = new();

    /// <summary>
    ///     The path to the identity config file.
    /// </summary>
    public static string IdentityConfigPath { get; set; } = "./data/misc/identity.careerconfig";
}