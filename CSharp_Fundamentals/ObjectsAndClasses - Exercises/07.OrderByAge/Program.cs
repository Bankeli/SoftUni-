namespace _07.OrderByAge
{
    internal class Program
    {
        public class Person
        {
            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

        }
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> personsList = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personData = input.Split();
                string name = personData[0];
                string id = personData[1];
                int age = int.Parse(personData[2]);

                Person existingPerson = personsList.FirstOrDefault(p => p.ID == id);

                if (existingPerson != null)
                {
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    personsList.Add(new Person(name, id, age));
                }
            }

            personsList = personsList.OrderBy(p => p.Age).ToList();

            PrintPersonData(personsList);

            
        }

        static void PrintPersonData(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
