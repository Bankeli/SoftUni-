using System.Net.Http.Headers;

namespace _05.Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintSumOfOrders(product, quantity);

            static void PrintSumOfOrders (string product, int quantity) 
            {
                double price = 0;
                if (product == "coffee")
                    price = 1.5;
                else if (product == "water")
                    price = 1.00;
                else if (product == "coke")
                    price = 1.4;
                else if (product == "snacks")
                    price = 2;
                else
                    return;

                    double sum = price * quantity;
                Console.WriteLine($"{sum:f2}");

            }
        }

       
    
    }

}
