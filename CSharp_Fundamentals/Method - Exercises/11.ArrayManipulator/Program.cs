using System;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        numbers = Exchange(numbers, index);
                        break;

                    case "max":
                        string maxType = arguments[1];
                        PrintMaxIndex(numbers, maxType);
                        break;

                    case "min":
                        string minType = arguments[1];
                        PrintMinIndex(numbers, minType);
                        break;

                    case "first":
                        int count = int.Parse(arguments[1]);
                        string firstType = arguments[2];
                        PrintFirstEvenOrOdd(numbers, count, firstType);
                        break;

                    case "last":
                        int lastCount = int.Parse(arguments[1]);
                        string lastType = arguments[2];
                        PrintLastEvenOrOdd(numbers, lastCount, lastType);
                        break;
                }

            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        

        static int[] Exchange(int[] numbers, int index)
        {
            if (index < 0 || index > numbers.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            int tempIndex = 0;
            int[] changedArrey = new int[numbers.Length];

            for (int i = index + 1; i <= numbers.Length - 1; i++)
            {
                changedArrey[tempIndex] = numbers[i];
                tempIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                changedArrey[tempIndex] = numbers[i];
                tempIndex++;
            }
            return changedArrey;

        }

        static void PrintMaxIndex(int[] numbers, string type)
        {
            int maxNumber = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int number = numbers[i];
                if (IsEvenOrOdd(type, number))
                {
                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintMinIndex(int[] numbers, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (IsEvenOrOdd(type, number))
                {
                    if (number <= minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }
            if (minIndex != -1)
            { Console.WriteLine(minIndex); }
            else
                Console.WriteLine("No matches");
        }

        static void PrintFirstEvenOrOdd(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            string firstElement = string.Empty;
            int elementCount = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                int number = numbers[i];
                if (IsEvenOrOdd(type, number))
                {
                    firstElement += $"{number}, ";
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{firstElement.Trim(' ', ',')}]");
        }

        static void PrintLastEvenOrOdd(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return ;
            }

            string lastElement = string.Empty;
            int elementCount = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int number = numbers[i];

                if (IsEvenOrOdd(type, number))
                    {
                    lastElement = $"{number}, " + lastElement;
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{lastElement.Trim(' ', ',')}]");
        }

        static bool IsEvenOrOdd(string type, int number)
        {
            return (type == "even" && number % 2 == 0) ||
                (type == "odd" && number % 2 != 0);

        }
    }
}
