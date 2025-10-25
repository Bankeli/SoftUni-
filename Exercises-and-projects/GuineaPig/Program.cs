namespace GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantityInKilos = double.Parse(Console.ReadLine());
            double hayInKilos = double.Parse(Console.ReadLine());
            double coverInKilos = double.Parse(Console.ReadLine());
            double pigWeightInKilos = double.Parse(Console.ReadLine());

            double foodInGrams = foodQuantityInKilos * 1000;
            double hayInGrams = hayInKilos * 1000;
            double coverInGrams = coverInKilos * 1000;
            double pigWeight = pigWeightInKilos * 1000;

            int days = 0;

            while (days <= 30)
            {
                days++;
                foodInGrams -= 300;
                double percent = 0;
                if (days % 2 == 0)
                {
                    percent = foodInGrams * 0.05;
                    hayInGrams -= percent;
                }
                if (days % 3 == 0)
                {
                    double quantityCover = pigWeight / 3;
                    coverInGrams -= quantityCover;
                }
                
                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
                if (days > 30)
                    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {Math.Ceiling(foodInGrams / 1000):f2}, Hay: {hayInGrams / 1000:f2}, Cover: {coverInGrams / 1000:f2}.");

            }
        }
    }
}
