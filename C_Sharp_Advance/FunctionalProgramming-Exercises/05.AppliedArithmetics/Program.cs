namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersColection = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add") TransformNum (numbersColection, x => x + 1);
                else if (command == "multiply") TransformNum (numbersColection, x => x * 2);
                else if (command == "subtract") TransformNum(numbersColection, x => x - 1);
                else if (command == "print") Console.WriteLine(string.Join(" ", numbersColection));
            }
        }

        static void TransformNum(int[] nums, Func<int, int> func)
        {
            for (int i = 0; i < nums.Length; i++)
            {
             nums[i] = func(nums[i]);   
            }
        }
    }
}
