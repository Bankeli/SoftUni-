namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new ();
            int startNum = 1;
            while (numbers.Count != 10)
            {
                try
                {
                    var number = ReadNumber(startNum, 100);
                    numbers.Add(number);
                    startNum = number;

                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid Number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }

        static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
                throw new Exception($"Your number is not in range {start} - {end}!");

            return num;
        }
    }
}
