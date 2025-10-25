namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] allBytes = File.ReadAllBytes(sourceFilePath);

            int partOneSize = (allBytes.Length + 1) / 2;
            int partTwoSize = allBytes.Length - partOneSize;

            byte[]partOneByte = new byte[partOneSize];
            byte[]partTwoByte = new byte[partTwoSize];

            Array.Copy(allBytes, 0, partOneByte, 0, partOneSize);
            Array.Copy(allBytes, partOneSize, partTwoByte, 0, partTwoSize);

            File.WriteAllBytes(partOneFilePath, partOneByte);
            File.WriteAllBytes(partTwoFilePath, partTwoByte);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] partOneBytes = File.ReadAllBytes(partOneFilePath);
            byte[] partTwoBytes = File.ReadAllBytes(partTwoFilePath);

            byte[] mergedBytes = new byte[partOneBytes.Length + partTwoBytes.Length];

            Array.Copy(partOneBytes, 0, mergedBytes, 0, partOneBytes.Length);
            Array.Copy(partTwoBytes, 0, mergedBytes, partOneBytes.Length, partTwoBytes.Length);

            File.WriteAllBytes(joinedFilePath, mergedBytes);
        }
    }
}