namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            ICallable callable = null;
            foreach (string number in phoneNumbers)
            {
                try
                {
                    callable = number.Length == 10
                        ? new Smartphone()
                        : new StationaryPhone();
                    Console.WriteLine(callable.Call(number));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
            }

            foreach (string url in urls)
            {
                try
                {
                    IBrowseable browsable = new Smartphone();
                    Console.WriteLine(browsable.Browse(url));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
