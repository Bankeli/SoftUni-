namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            int price = 0;
            if (ages >= 0 && ages <= 18)
            {
                if (typeOfTheDay == "Weekday")
                    price = 12;
                else if (typeOfTheDay == "Weekend")
                    price = 15;
                else if (typeOfTheDay == "Holiday")
                    price = 5;
            }
            else if (ages > 18 && ages <= 64)
            {
                if (typeOfTheDay == "Weekday")
                    price = 18;
                else if (typeOfTheDay == "Weekend")
                    price = 20;
                else if (typeOfTheDay == "Holiday")
                    price = 12;
            }
            else if (ages > 64 && ages <= 122)
            {
                if (typeOfTheDay == "Weekday")
                    price = 12;
                else if (typeOfTheDay == "Weekend")
                    price = 15;
                else if (typeOfTheDay == "Holiday")
                    price = 10;
            }
            else
            {
                Console.WriteLine("Error!");
            }

            if(price != 0)
            Console.WriteLine($"{price}$");
        }
    }
}
