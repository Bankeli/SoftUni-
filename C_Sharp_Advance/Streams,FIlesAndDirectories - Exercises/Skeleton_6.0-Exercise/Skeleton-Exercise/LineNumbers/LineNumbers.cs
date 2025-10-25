using System.IO;
using System.Net;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
           string[] lines = File.ReadAllLines(inputFilePath);

           for(int i =0;i<lines.Length;i++)
               lines[i] = FormatedText(lines[i], i);
           
           File.WriteAllLines(outputFilePath, lines);
        }

        private static string FormatedText(string line, int index)
        {
            int lettersCount = 0;
            int punctuationCount = 0;

            foreach (char ch in line)
            {
                if (char.IsLetter(ch))
                    lettersCount++;
                if (char.IsPunctuation(ch))
                    punctuationCount++;
            
            }
            return line = $"Line {index + 1}: {line} ({lettersCount}) ({punctuationCount})";
        }
    }
}
