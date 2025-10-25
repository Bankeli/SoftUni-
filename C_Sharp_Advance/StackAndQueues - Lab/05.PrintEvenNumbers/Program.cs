namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queque = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> list = new List<int>();

            while (queque.Count > 0)
            {
                var num = queque.Dequeue();
                if (num % 2 == 0)
                {
                    list.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
