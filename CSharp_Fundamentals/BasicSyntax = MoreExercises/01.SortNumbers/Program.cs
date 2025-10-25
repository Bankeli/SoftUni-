namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int[] nums = {n1,n2,n3};

            Array.Sort(nums);
            Array.Reverse(nums);

            foreach (int number in nums)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
