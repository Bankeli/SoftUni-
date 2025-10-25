namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new();

            for (int i = 0; i < studentsCount; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var evaluation = decimal.Parse(input[1]);

                if(!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<decimal>();
                }
                studentGrades[name].Add(evaluation);
            }

            foreach (var (name, grades) in studentGrades)
            {
                Console.WriteLine($"{name} -> {string.Join(" ", grades.Select(g => g.ToString("f2")))} (avg: {grades.Average():f2})");
            }
        }
    }
}
