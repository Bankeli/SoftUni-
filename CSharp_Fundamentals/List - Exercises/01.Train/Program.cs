namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();
                if (data[0] == "Add")
                {
                    AddPasanger(data, train);
                }
                else 
                { 
                    FillWagons(train, maxCapacity, data);
                }
            }

            Console.WriteLine(string.Join(" ",train));
        }

        private static void FillWagons(List<int> train, int maxCapacity, string[] data)
        {
            int passanger = int.Parse(data[0]);
            for (int i = 0; i < train.Count; i++)
            {
                if (train[i] + passanger <= maxCapacity)
                {
                train[i] += passanger;
                    return;
                }
               
            }
        }

        static void AddPasanger(string[] input, List<int>train)
        {
           if( input[0] == "Add")
                train.Add(int.Parse(input[1]));
           return;
        }

    }
}
