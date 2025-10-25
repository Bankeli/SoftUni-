namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            

            if (day == "Friday")
            {
                if (peopleType == "Students")
                {
                    price = 8.45;
                }
                else if (peopleType == "Business")
                {
                    price = 10.90;
                }
                else if (peopleType == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (peopleType == "Students")
                {
                    price = 9.80;
                }
                else if (peopleType == "Business")
                {
                    price = 15.60;
                }
                else if (peopleType == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (peopleType == "Students")
                {
                    price = 10.46;
                }
                else if (peopleType == "Business")
                {
                    price = 16;
                }
                else if (peopleType == "Regular")
                {
                    price = 22.50;
                }
            }
            if (peopleType == "Business" && peopleCount >= 100)
                peopleCount -= 10;
            double totalPrice = price * peopleCount;

            if (peopleType == "Students" && peopleCount >= 30)
                totalPrice *= 0.85;
            
            else if (peopleType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
                totalPrice *= 0.95;

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
