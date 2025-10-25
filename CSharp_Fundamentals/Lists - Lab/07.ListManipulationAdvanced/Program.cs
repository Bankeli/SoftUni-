using System.Security.Principal;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
                int commandCount = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Contains":
                        int numCont = int.Parse(arguments[1]);
                        if (numberList.Contains(numCont))
                        {
                            Console.WriteLine("Yes");
                        }
                        else Console.WriteLine("No such number");
                        
                        break;
                    case "PrintEven":
                        List<int> evenList = new();
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            {
                                if (numberList[i] % 2 == 0)
                                    evenList.Add(numberList[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",evenList));
                        
                        break;
                    case "PrintOdd":
                        List <int> oddList = new();
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            {
                                if (numberList[i] % 2 != 0)
                                    oddList.Add(numberList[i]);
                            }
                        }
                        Console.WriteLine(string.Join (" ",oddList));
                        
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            sum += numberList[i];
                        }
                        Console.WriteLine(sum);
                        
                        break;

                    case "Filter":
                        string condition = (arguments[1]);
                        int number = int.Parse(arguments[2]);
                        PrintFilterOperation(condition, number, numberList);
                        
                        break;
                    case "Add":
                        int numer = int.Parse(arguments[1]);
                        numberList.Add(numer);
                        commandCount++;
                        break;
                    case "Remove":
                        int num = int.Parse(arguments[1]);
                        numberList.Remove(num);
                        commandCount++;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(arguments[1]);
                        numberList.RemoveAt(index);
                        commandCount++;
                        break;
                    case "Insert":
                        int nums = int.Parse(arguments[1]);
                        int addedIndex = int.Parse(arguments[2]);
                        numberList.Insert(addedIndex, nums);
                        commandCount++;
                        break;
                }
            }

            if (commandCount > 0)
            {
                Console.WriteLine(string.Join(" ", numberList));
            }

            
                static void PrintFilterOperation(string symbol, int number, List<int> numList)
                {
                List<int> workingList = new ();
                    switch (symbol)
                    {

                        case "<":
                            for (int i = 0; i < numList.Count; i++)
                            {
                                if (numList[i] < number)
                                workingList.Add(numList[i]);
                                    
                            }
                        Console.WriteLine(string.Join(" ",workingList));
                            break;
                        case ">":
                            for (int i = 0; i < numList.Count; i++)
                            {
                                if (numList[i] > number)
                                workingList.Add(numList[i]);
                        }
                        Console.WriteLine(string.Join(" ", workingList));
                        break;
                        case "<=":
                            for (int i = 0; i < numList.Count; i++)
                            {
                                if (numList[i] <= number)
                                workingList.Add(numList[i]);
                        }
                        Console.WriteLine(string.Join(" ", workingList));
                        break;
                        case ">=":
                            for (int i = 0; i < numList.Count; i++)
                            {
                                if (numList[i] >= number)
                                workingList.Add(numList[i]);
                        }
                        Console.WriteLine(string.Join(" ", workingList));
                        break;
                    }
                }

        }
    }
}
