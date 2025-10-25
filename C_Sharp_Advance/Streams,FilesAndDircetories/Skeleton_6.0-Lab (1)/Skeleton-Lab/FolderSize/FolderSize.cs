namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            long totalBytes = 0;

            
            foreach (string file in allFiles)
            {
                FileInfo fi = new FileInfo(file);
                totalBytes += fi.Length;
            }

            
            double sizeInKB = totalBytes / 1024.0;

           
            File.WriteAllText(outputFilePath, sizeInKB.ToString());
        }
    }
}
