using System.Reflection.Metadata.Ecma335;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersArr = Console.ReadLine().Split().ToArray();
            List<int> validNum = new();
            int sum = 0;

            foreach (var element in numbersArr)
            {
                try
                {
                    var num = int.Parse(element);
                    sum += num;
                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
