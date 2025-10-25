

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyPerson = new List<Person>();
       

        public void AddMember(Person person)
        { 
            this.familyPerson.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.familyPerson.MaxBy(p => p.Age);
        }
    }
}
