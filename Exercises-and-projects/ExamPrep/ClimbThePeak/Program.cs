namespace ClimbThePeak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mountainsDifficulties = new Dictionary<string, int>
            {
                {"Vihren",80 },
                {"Kutelo",90 },
                {"Banski Suhodol",100},
                {"Polezhan", 60 },
                {"Kamenitza",70 }
            };

            Queue<string> peaks = new Queue<string>(mountainsDifficulties.Keys);
            List<string> conqueredPeaks = new List<string>();

            Stack<int> food = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            bool isTopReach = false;

            while (food.Count > 0 && stamina.Count > 0 && peaks.Count > 0)
            {
                int dailyFood = food.Pop();
                int dailyStamina = stamina.Dequeue();
                int dailyNeed = dailyFood + dailyStamina;
                string peakName = peaks.Peek();
                int peekDiff = mountainsDifficulties[peakName];

                if (dailyNeed >= peekDiff)
                {
                    conqueredPeaks.Add(peaks.Dequeue());
                }
            }
           if(peaks.Count == 0) isTopReach = true;

            if (isTopReach) Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            else Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");

            if (conqueredPeaks.Count > 0)
            {
                Console.WriteLine("Conquered peaks:");
                foreach (string peak in conqueredPeaks) Console.WriteLine(peak);
            }

        }
    }
}
