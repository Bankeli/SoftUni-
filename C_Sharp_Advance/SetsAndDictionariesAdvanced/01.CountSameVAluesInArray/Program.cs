var array = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    
    .ToArray();

Dictionary<string,int> arrayMap = new();

for (int i = 0; i < array.Length; i++)
{
    if (!arrayMap.ContainsKey(array[i]))
    {
        arrayMap[array[i]] = 0;
    }
    arrayMap[array[i]]++;
}

foreach (var (number, count) in arrayMap)
{
    Console.WriteLine($"{number} - {count} times");
}
