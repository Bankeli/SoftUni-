using System.ComponentModel.Design;

namespace _04.Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Student> studentsList = new List<Student>();
            while ((command = Console.ReadLine()) != "end") 
            {
                string[] arguments = command.Split();

                if (IsStudentExist(studentsList, arguments[0], arguments[1]))
                {
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = arguments[0];
                    student.LastName = arguments[1];
                    student.Age = int.Parse(arguments[2]);
                    student.Town = arguments[3];

                    studentsList.Add(student);
                }
            }

            string homeTown = Console.ReadLine();
            CheckIfTheSudentIsFromTheTown(studentsList, homeTown);
            
        }
        static void CheckIfTheSudentIsFromTheTown(List<Student>studentList, string city)
        {
            foreach (Student student in studentList)
            {
                if (student.Town == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students) 
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                    return true;
            }
            return false;
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}
