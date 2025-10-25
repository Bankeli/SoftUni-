using System.IO;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(inputPath);

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                File.Copy(fileInfo.FullName, Path.Combine(outputPath, fileInfo.Name), true);
            }
        }
    }
}
