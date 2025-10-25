namespace ArmstrongNumbers;

class Program
{
    static void Main(string[] args)
    {
       int num = int.Parse(Console.ReadLine());
       int[]digits = num.ToString().Select(c => int.Parse(c.ToString())).ToArray();

     
       int sum = 0;

       for (int i = 0; i < digits.Length; i++)
       {
           double powSum = Math.Pow(digits[i],digits.Length);
           sum += (int)powSum;
       }
       
       string isNarcis = sum==num ? "Yes" : "No";
       
       Console.WriteLine(isNarcis); 
       
    }
}