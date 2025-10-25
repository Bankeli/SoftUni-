using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal pricePerCapsule = 0;
            int days = 0;
            int capsuleCount = 0;
            decimal totalSum = 0;

            for (int i = 1; i <= countOfOrders; i++)
            { 
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCount = int.Parse(Console.ReadLine());

                decimal orderPrice = days * pricePerCapsule * capsuleCount;
                totalSum += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}") ;

            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
