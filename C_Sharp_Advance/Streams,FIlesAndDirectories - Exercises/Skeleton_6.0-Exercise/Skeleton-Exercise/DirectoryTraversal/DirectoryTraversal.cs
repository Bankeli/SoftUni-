using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;

    public class DirectoryTraversal
    {
        static void Main()
        {

           
            string path = Console.ReadLine();
            string reportFileName = @"report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(inputFolderPath);

            Dictionary<string, List<FileInfo>> filesMap = new Dictionary<string, List<FileInfo>>();
            foreach (FileInfo file in directory.GetFiles())
            {
                if (!filesMap.ContainsKey(file.Extension))
                    filesMap[file.Extension] = new List<FileInfo>();

                filesMap[file.Extension].Add(file);
            }
                StringBuilder sb = new StringBuilder();
            foreach ((string extension, List<FileInfo> files) in filesMap
                         .OrderByDescending(x => x.Value.Count)
                         .ThenBy(x => x.Key))
            {
                
                sb.AppendLine(extension);
                foreach (FileInfo file in files.OrderBy(x => x.Length))
                {
                    sb.AppendLine($"--{file.Name} - {file.Length / 1024m}kb");
                }
            }
            
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
          string destinationPath =  Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
          
          File.WriteAllText(Path.Combine(destinationPath, reportFileName), textContent);
        }
    }
}