namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
           HashSet<byte> bytesToExtract = new(File.ReadAllLines(bytesFilePath).Select(line => byte.Parse(line)));

            byte[] binaryData = File.ReadAllBytes(binaryFilePath);

            List<byte> extract = new List<byte>();

            foreach (var bytes in binaryData)
            {
                if (bytesToExtract.Contains(bytes))
                    extract.Add(bytes);
            }

            File.WriteAllBytes(outputPath, extract.ToArray());
        }
    }
}
