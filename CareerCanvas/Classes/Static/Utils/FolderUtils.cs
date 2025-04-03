using System.Diagnostics;

namespace CareerCanvas.Classes.Static.Utils;

public static class FolderUtils
{
    /// <summary>
    /// Folders that are expected to exist in the application directory.
    /// </summary>
    private static readonly List<string> expectedFolders = new List<string>
    {
        "./data",
        "./data/misc",
        "./data/configs",
        "./data/resumes",
        "./data/coverletters",
        "./data/identities",
        "./data/industries",
    };

    /// <summary>
    /// Creates a folder at the specified path if it does not already exist.
    /// </summary>
    /// <param name="folderPath">The path of the folder to create.</param>
    public static void CreateFolderIfNotExists(string folderPath)
    {
        if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
    }

    /// <summary>
    /// Creates the necessary application folders if they do not already exist.
    /// This includes folders for data storage and templates for resumes and cover letters.
    /// </summary>
    public static void CreateAppFolders()
    {
        foreach (string folder in expectedFolders)
        {
            CreateFolderIfNotExists(folder);
        }
    }

    /// <summary>
    /// Opens a folder in the file explorer.
    /// </summary>
    /// <param name="folderPath">The path of the folder to be opened.</param>
    public static void OpenFolder(string folderPath)
    {
        Process.Start("explorer.exe", folderPath);
    }
}