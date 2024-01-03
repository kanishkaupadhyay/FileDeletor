namespace FileDeletor
{
    public class FileDeletor
    {
        public static bool DeleteFilesFromPath(string path)
        {
            bool success = false;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                    if (files != null)
                    {
                        Console.WriteLine($"Number of files to delete: ");
                        
                        FileInfo fileInfo;
                        foreach (string filePath in files)
                        {
                            fileInfo = new FileInfo(filePath);
                            Console.WriteLine($"File Information");
                            Console.WriteLine($"File Name: {fileInfo.Name}, File Extension: {fileInfo.Extension}, File Size: {fileInfo.Length}, File Creation Date: {fileInfo.CreationTimeUtc.Date}");
                            Console.WriteLine("Deleting File: " + filePath);
                            File.Delete(filePath);
                        }
                        success = true;
                    }
                    Console.WriteLine("No files found under this folder.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return success;
        }
    }
}
