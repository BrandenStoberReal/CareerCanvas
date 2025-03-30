using CareerCanvas.Classes.Static;
using CareerCanvas.Forms;
using ProtoBuf;

namespace CareerCanvas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Run code on program close
            Application.ApplicationExit += OnApplicationExit;

            Application.Run(new EntryForm());
        }

        private static void OnApplicationExit(object? sender, EventArgs e)
        {
            // Save identity settings
            using (FileStream file = File.Create(Globals.IdentityConfigPath))
            {
                Serializer.Serialize(file, Globals.IdentityConfig);
            }

            // Encrypt identity settings
            EncryptionUtils.EncryptFile(Globals.IdentityConfigPath, Globals.IdentityConfigPath, File.ReadAllText("./data/misc/encryption.key"));
        }
    }
}