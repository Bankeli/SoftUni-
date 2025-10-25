using Microsoft.VisualBasic;

var contestant = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
var pies = new Stack<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (contestant.Count > 0 && pies.Count > 0)
{
    var currentContestant = contestant.Dequeue();
    var currentPie = pies.Pop();

    if (currentContestant >= currentPie)
    {
        currentContestant -= currentPie;
        
           
        if (currentContestant > 0)
            
        contestant.Enqueue(currentContestant);
    }
    else
    {
        currentPie -= currentContestant;
        if (currentPie == 1)
        {
            if (pies.Count > 0)
            {
                int nextPie = pies.Pop();
                pies.Push(nextPie + 1); 
            }
            else
            {
                pies.Push(1); 
            }
        }
        else
        {
            pies.Push(currentPie); 
        }
    }
}

if (pies.Count == 0 && contestant.Count > 0)
{
    Console.WriteLine("We will have to wait for more pies to be baked!");
    Console.WriteLine($"Contestants left: {string.Join(", ", contestant)}");
}
else if (pies.Count == 0 && contestant.Count == 0)
{
    Console.WriteLine("We have a champion!");
}
else if (contestant.Count == 0 && pies.Count > 0)
{
    Console.WriteLine("Our contestants need to rest!");
    Console.WriteLine($"Pies left: {string.Join(", ", pies.Reverse())}");
}