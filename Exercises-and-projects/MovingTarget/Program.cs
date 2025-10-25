namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); 
            
            string input = string.Empty;
            int index = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                index = int.Parse(arguments[1]);

                switch (arguments[0])
                {
                    case "Shoot":
                        int powerOfShot = int.Parse(arguments[2]);

                        if(index< 0 || index > targetsSequence.Count - 1)
                        {
                            continue;
                        }
                        else
                            targetsSequence[index] -= powerOfShot;

                        if(targetsSequence[index] <= 0)
                            targetsSequence.RemoveAt(index);

                            break;


                    case "Add":
                        int value = int.Parse(arguments[2]);

                        if (index < 0 || index > targetsSequence.Count - 1)
                        {
                            Console.WriteLine("Invalid placement!");
                            continue;
                        }
                        else 
                            targetsSequence.Insert(index, value);
                            break;

                    case "Strike":
                        int radius = int.Parse(arguments[2]);

                        if (index - radius < 0 || index + radius > targetsSequence.Count - 1)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                        else
                        {
                            targetsSequence.RemoveRange(index - radius, radius * 2 + 1);
                        }
                            break;
                }
            }

            Console.WriteLine(string.Join("|",targetsSequence));
        }
    }
}
