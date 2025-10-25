namespace _05.FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int counter = 1;
            int remainingCapacity = rackCapacity;
            while (clothes.Count > 0)
            {
                int cloth = clothes.Pop();
                if (cloth > remainingCapacity)
                {
                    counter++;
                    remainingCapacity = rackCapacity;
                }
               
                remainingCapacity -= cloth;
            }

            Console.WriteLine(counter);
            
        }
    }
}
