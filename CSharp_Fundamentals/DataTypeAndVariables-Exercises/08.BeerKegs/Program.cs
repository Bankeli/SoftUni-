namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string biggestModel = string.Empty;
            double volume = 0;

            for (int i = 1; i <= number; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeCalc = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeCalc > volume)
                {
                    biggestModel = model;
                    volume = volumeCalc;
                }



            }

            Console.WriteLine(biggestModel);
        }
    }
}
