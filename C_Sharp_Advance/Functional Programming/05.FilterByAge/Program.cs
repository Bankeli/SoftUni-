using System.Threading.Channels;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var peopleMap = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] peopleData = Console.ReadLine().Split(", ");
                string name = peopleData[0];
                int age = int.Parse(peopleData[1]);

                peopleMap.Add(name, age);
            }

            var condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            peopleMap = SortedDictionary(peopleMap, condition, ageCondition);

            FormatPrint(peopleMap, format);
        }

        static Dictionary<string, int> SortedDictionary(Dictionary<string, int> peopleMap, string condition, int ageCondition)
        {
            var people = new Dictionary<string, int>();

            if (condition == "younger")
            {
                foreach ((string name, int age) in peopleMap)
                {
                    if (age < ageCondition)
                        people.Add(name, age);
                }
            }
            else
            {
                foreach ((string name, int age) in peopleMap)
                {
                    if (age >= ageCondition)
                        people.Add(name, age);
                }
            }

                return people;
        }

        static void FormatPrint(Dictionary<string, int>people, string format)
        {
            if (format == "name")
                foreach ((string name, int age) in people)
                    Console.WriteLine(name);
            else if (format == "age")
                foreach ((string name, int age) in people)
                    Console.WriteLine(age);
            else
                foreach((string name, int age) in people)
                    Console.WriteLine($"{name} - {age}");
        }
    }
}
