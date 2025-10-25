

namespace Person
{
    public class Person
    {
        private int age;
        private string name;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    this.age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        => $"{this.GetType().Name} -> Name: {Name}, Age: {Age}";


    }
}
