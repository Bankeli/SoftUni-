namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberMessages = int.Parse(Console.ReadLine());

            string[] phrase = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            ReturnRandomMessage(phrase, events, author, cities, numberMessages);

            
        }

        static void ReturnRandomMessage(string[] phrase, string[] events, string[] author, string[] cities, int number)
        {
            Random randomMessage = new Random();

            for (int i = 0; i < number; i++)
            {
                string text = phrase[randomMessage.Next(phrase.Length)];
                string eventMessage = events[randomMessage.Next(events.Length)];
                string messageAutor = author[randomMessage.Next(author.Length)];
                string city = cities[randomMessage.Next(cities.Length)];

                string message = $"{text} {eventMessage} {messageAutor} - {city}.";

                Console.WriteLine(message);
            }
        }
    }
}
