
namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse);
            Queue<int> ordersQueue = new Queue<int>(orders);

            int biggestOrder = ordersQueue.Max();

            while (ordersQueue.Count > 0)
            {
                int orderCheck = ordersQueue.Peek();
                if (foodQuantity >= orderCheck)
                {
                    int order = ordersQueue.Dequeue();

                    foodQuantity -= order;

                }
                else 
                {
                    break;
                }

            }

                Console.WriteLine(biggestOrder);
            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
            }
        }
    }
}
