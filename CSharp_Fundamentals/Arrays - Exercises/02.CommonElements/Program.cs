namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split()
                .ToArray();

            //foreach (string element in secondArray)
            //{
            //    foreach (string items in firstArray)
            //    {
            //        if (items == element)
            //        {
            //            Console.Write($"{element} ");
            //            break;
            //        }
            //    }
            //}

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                { 
                    if (secondArray[i] == firstArray[j])
                        Console.Write($"{secondArray[i]} ");
                }
            }
        }


    }
}
