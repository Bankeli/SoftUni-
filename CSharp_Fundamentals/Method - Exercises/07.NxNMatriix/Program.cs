using System.Data;

namespace _07.NxNMatriix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           NxNMatrix(number);
        }

        static void NxNMatrix(int num1)
        {
            int rows = 0;
            while (rows < num1) 
            {
                for (int i = 0; i < num1; i++)
                {
                    Console.Write(num1 + " ");
                }
                Console.WriteLine();
                    rows++;
            }
        }
    }
}
