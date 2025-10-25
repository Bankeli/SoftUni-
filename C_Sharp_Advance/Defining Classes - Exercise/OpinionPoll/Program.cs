namespace OpinionPoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            List<Person> personList = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                int age = int.Parse(data[1]);

                Person person = new Person(name, age);
                personList.Add(person);
            }

            personList = personList.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (Person person in personList)
                Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
