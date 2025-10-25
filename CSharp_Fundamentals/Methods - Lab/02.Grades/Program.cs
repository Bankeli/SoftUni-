namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeWithWords(grade);

        }

        static void GradeWithWords(double grade)
        {
            string gradeValue = string.Empty;
            if (grade >= 2 && grade <= 2.99)
                gradeValue = "Fail";
            else if (grade >= 3 && grade <= 3.49)
                gradeValue = "Poor";
            else if (grade >= 3.5 && grade <= 4.49)
                gradeValue = "Good";
            else if (grade >= 4.5 && grade <= 5.49)
                gradeValue = "Very good";
            else if (grade >= 5.5 && grade <= 6)
                gradeValue = "Excellent";
            Console.WriteLine(gradeValue);
        }
    }
}
