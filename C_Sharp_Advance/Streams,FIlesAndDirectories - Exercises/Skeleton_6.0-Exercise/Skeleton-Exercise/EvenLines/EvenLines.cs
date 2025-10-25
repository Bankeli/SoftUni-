using System.IO;
using System.Net.Http;
using System.Text;

namespace EvenLines
{
    using System;

    public class EvenLines
    {
        
        private static char[] SymbolForReplace = ['-',',','.','!','?'];

        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using var streamReader = new StreamReader(inputFilePath);
            bool isEven = true;
                StringBuilder sb = new StringBuilder();
            while (!streamReader.EndOfStream)
            {
                string lines = streamReader.ReadLine();
                if (isEven)
                {
                    sb.Append(Format(lines));
                }
                isEven = !isEven;
            }

            return sb.ToString();
        }

        private static string Format(string lines)
        {
            string[] words = lines.Split();
            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < SymbolForReplace.Length; j++)
                    words[i] = words[i].Replace(SymbolForReplace[j], '@');
            }

            return string.Join(' ', words);
        }
        
    }
}