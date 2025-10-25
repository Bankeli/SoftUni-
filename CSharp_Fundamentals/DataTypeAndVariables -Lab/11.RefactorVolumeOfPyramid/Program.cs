namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            double volume = (lenght * width * height) / 3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {volume:f2}");


        }
    }
}
