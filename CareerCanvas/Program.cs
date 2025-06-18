using CareerCanvas.Classes.Main.Protobuf;
using CareerCanvas.Classes.Static;
using CareerCanvas.Classes.Static.Utils;
using CareerCanvas.Forms;
using ProtoBuf;

namespace CareerCanvas;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Run code on program close
        Application.ApplicationExit += OnApplicationExit;
        Globals.AppLogger.Debug("Application exit event handler registered.");

        // Create necessary application folders if they do not exist
        FolderUtils.CreateAppFolders();
        Globals.AppLogger.Debug("Created necessary application folders.");

        // Create an encryption key if it does not exist
        if (!File.Exists("./data/misc/encryption.key"))
        {
            Globals.AppLogger.Warning("Encryption key not found. Generating new key.");
            File.WriteAllText("./data/misc/encryption.key", EncryptionUtils.Generate256BitKey());
        }

        // Load secrets
        if (File.Exists("./data/misc/secrets.csm"))
        {
            using (var file = File.OpenRead("./data/misc/secrets.csm"))
            {
                Globals.AiSecrets = Serializer.Deserialize<AiSecrets>(file);
                Globals.AppLogger.Information("AI secrets loaded.");
            }
        }
        else
        {
            Globals.AppLogger.Warning("AI secrets not found. Creating new secrets config.");
        }

        // Load preferences
        if (File.Exists("./data/misc/prefs.pns"))
        {
            using (var file = File.OpenRead("./data/misc/prefs.pns"))
            {
                Globals.Preferences = Serializer.Deserialize<Preferences>(file);
                Globals.AppLogger.Information("Preferences loaded.");
            }
        }
        else
        {
            Globals.AppLogger.Warning("Preferences not found. Creating new preferences.");
        }

        Globals.AppLogger.Information("Starting application...");
        Application.Run(new EntryForm());
    }

    private static void OnApplicationExit(object? sender, EventArgs e)
    {
        // Save identity settings
        using (var file = File.Create(Globals.IdentityConfigPath))
        {
            Serializer.Serialize(file, Globals.IdentityConfig);
            Globals.AppLogger.Information("Identity settings saved.");
        }

        // Save AI secrets
        using (var file = File.Create("./data/misc/secrets.csm"))
        {
            Serializer.Serialize(file, Globals.AiSecrets);
            Globals.AppLogger.Information("AI secrets saved.");
        }

        // Save preferences
        using (var file = File.Create("./data/misc/prefs.pns"))
        {
            Serializer.Serialize(file, Globals.Preferences);
            Globals.AppLogger.Information("Preferences saved.");
        }

        // Encrypt identity settings
        EncryptionUtils.EncryptFile(Globals.IdentityConfigPath, Globals.IdentityConfigPath,
            File.ReadAllText("./data/misc/encryption.key"));
        Globals.AppLogger.Debug("Identity settings encrypted.");
    }
}