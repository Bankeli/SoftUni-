
using BorderControl.Model.Inferfaces;
using System.Data.Common;

namespace BorderControl.Model
{
    public class Citizen : IPerson
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
