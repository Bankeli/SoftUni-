

using System.Xml.Linq;

namespace _06.StudentsAcademy
{
    internal class Program
    {
        public class Students
        {

            public string Name { get; set; }
            public List<decimal> Grade { get; set; } = new List<decimal>();
        }
        static void Main(string[] args)
        {
            Dictionary<string, Students> studentsMap = new Dictionary<string, Students>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                if (!studentsMap.ContainsKey(studentName))
                {
                    studentsMap.Add(studentName, new Students());
                   
                }
                studentsMap[studentName].Name = studentName;
                studentsMap[studentName].Grade.Add(grade);
            }

            foreach (var students in studentsMap)
            {
               
                decimal average = students.Value.Grade.Average();
                if (average >= 4.50M)
                {
                    Console.WriteLine($"{students.Key} -> {average:f2}");
                }
            }

        }
    }
}
