namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //string text = Console.ReadLine();

                //Box<string> box = new Box<string>(text);
                //Console.WriteLine(box);

                int num = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(num);
                Console.WriteLine(box);
            }
        }
           
    }
}
