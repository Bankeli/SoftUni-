namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            Math.Abs(startingNum);
           
            while (startingNum % 2 != 0 )
            {
                Console.WriteLine("Please write an even number.");
                startingNum = int.Parse(Console.ReadLine());
                
                
            }
            Console.WriteLine($"The number is: {Math.Abs(startingNum)}");
        }
    }
}
