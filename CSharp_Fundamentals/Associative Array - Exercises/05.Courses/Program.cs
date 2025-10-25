namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> coursesMap = new Dictionary<string,List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] coursesData = input.Split(" : ");
                string course = coursesData[0];
                string studentName = coursesData[1];

                if (!coursesMap.ContainsKey(course))
                {
                    coursesMap.Add(course, new List<string>());
                }

                coursesMap[course].Add(studentName);
                
            }

            foreach ((string course, List<string> students) in coursesMap)
            {
                Console.WriteLine($"{course}: {students.Count}");
                foreach (string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }    
        }
    }
}
