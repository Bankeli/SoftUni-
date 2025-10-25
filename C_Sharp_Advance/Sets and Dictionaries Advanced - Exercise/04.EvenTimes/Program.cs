namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> CountByNumber = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(!CountByNumber.ContainsKey(num))
                    CountByNumber[num] = 0;

                CountByNumber[num]++;
            }

            foreach (var (num,count) in CountByNumber)
            {
                if (count % 2 == 0)
                    Console.WriteLine(num);
            }    
        }
    }
}
