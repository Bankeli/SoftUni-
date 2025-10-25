namespace _04.Students
{
    internal class Program
    {
        public class Students
        {
            public Students(string firstName, string secondName, decimal grade)
            {
                FirstName = firstName;
                LastName = secondName;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Grade { get; set; }
        }
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentsData = Console.ReadLine().Split();
                string firstName = studentsData[0];
                string lastName = studentsData[1];
                decimal grade = decimal.Parse(studentsData[2]);

                Students students = new Students(firstName, lastName, grade);
                
                studentsList.Add(students);
            }

           studentsList = studentsList.OrderByDescending(s  => s.Grade).ToList();

            foreach (Students students in studentsList)
            {
                Console.WriteLine($"{students.FirstName} {students.LastName}: {students.Grade}");
            }
        }
    }
}
