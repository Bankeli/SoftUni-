using BorderControl.Model;
using BorderControl.Model.Inferfaces;
using System.Net;

namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = string.Empty;
            List<IBirthable> birthables = new();
          while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];

                    Citizen citizen = new Citizen(name,age,id,birthdate);
                    birthables.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];
                    string birthdate = tokens[2];

                    Pet pet = new Pet(name, birthdate);
                    birthables.Add(pet);
                }
                else
                    continue;
            }

          string year = Console.ReadLine();
           
          foreach (var birthday in birthables)
            {
                if (birthday.Birthdate.EndsWith(year))
                    Console.WriteLine(birthday.Birthdate);
            }
            
        }
    }
}
