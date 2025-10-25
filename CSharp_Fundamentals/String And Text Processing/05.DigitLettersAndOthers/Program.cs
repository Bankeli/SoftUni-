namespace _05.DigitLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           
            string[] chars = new string[3];

            foreach (char ch in text)
            {
                if(char.IsDigit(ch))
                {
                    chars[0]+=(ch);   
                }


                else if (char.IsLetter(ch))
                {
                    chars[1]+=(ch);

                }

                else
                {
                    chars[2]+=(ch);
                }

            }
            foreach (var group in chars)
            {
                Console.WriteLine(string.Join("",group));
            }
        }
    }
}
