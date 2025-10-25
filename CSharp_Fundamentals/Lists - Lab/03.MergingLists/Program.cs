namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<int> number1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> number2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int MaxLenght = number1.Count > number2.Count
                ? number1.Count
                : number2.Count;

            List<int> mergedList = new();

            for (int i = 0; i < MaxLenght; i++)
            {
                if (number1.Count > i)
                    mergedList.Add(number1[i]);

                if (number2.Count > i)
                    mergedList.Add(number2[i]);
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
