namespace CareerCanvas.Classes.Static
{
    public static class FolderUtils
    {
        public static void CreateFolderIfNotExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        public static void CreateAppFolders()
        {
            CreateFolderIfNotExists("./data");
            CreateFolderIfNotExists("./data/resumes");
            CreateFolderIfNotExists("./data/coverletters");
            CreateFolderIfNotExists("./data/identities");
        }
    }
}