namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = PrintRectangleArea(width, height);
            Console.WriteLine(area);
        }

        static int PrintRectangleArea(int a, int b) 
        {
            int result = a * b;
            return result;

        }
    }
}
