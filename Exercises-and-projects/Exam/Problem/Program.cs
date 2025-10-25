
namespace Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int freeFlour = students / 5;

            double totalAprons = Math.Ceiling(students * 1.2) * apronPrice;
            double neededFlour = (students - freeFlour) * flourPrice;
            double neededEggs = students * 10 * singleEggPrice;

            double totalSum = neededFlour + totalAprons + neededEggs;

            if (budget >= totalSum) 
            {
                Console.WriteLine($"Items purchased for {totalSum:F2}$."); ;
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget - totalSum):f2}$ more needed.");
            }
        }
    }
}
            