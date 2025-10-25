

using System.Threading.Channels;

namespace _04.ListOperation
{
    internal class Program
    {
        static List<int> NumList = new();
        static void Main(string[] args)
        {
            NumList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string action = arguments[0];

                switch (action)
                {
                    case "Add":
                        AddNumber(int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        InsertNumber(int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        RemoveNumber(int.Parse(arguments[1]));
                        break;
                    case "Shift":
                        ChangeNumberPosition(arguments[1],  int.Parse(arguments[2]));
                        break;

                }
            }
            Console.WriteLine(string.Join(" ",NumList));
        }

        

        private static bool IsValid(int index)
        {
            if (index < 0 || index > NumList.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return false;
            }

            return true;
        }

        private static void AddNumber(int number)
        {
            NumList.Add(number);
        }

        private static void InsertNumber(int number, int index)
        {

            if (!IsValid(index))
            {
                return;
            }
            NumList.Insert(index, number);
        }

        private static void RemoveNumber(int index)
        {
            if (!IsValid(index))
            {
                return; 
            }
            NumList.RemoveAt(index);
        }

        private static void ChangeNumberPosition(string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int currentNum = NumList[0];
                    NumList.Remove(currentNum);
                    NumList.Add(currentNum);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    int currentNum = NumList[NumList.Count-1];
                    NumList.Remove(currentNum);
                    NumList.Insert(0, currentNum);
                }
            }
        }
    }
}
