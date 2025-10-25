namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek =
            {
                "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"

            };
            int day = int.Parse(Console.ReadLine());

            
                if (day >0 && day <= 7) 
            {
                day--;
            Console.WriteLine(daysOfTheWeek[day]);
            }
            else
                Console.WriteLine("Invalid day!");
            
        }
    }
}
