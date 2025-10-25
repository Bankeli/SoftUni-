namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] data = input.Split(":");
                string command = data[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(data[1]);
                        string strToAdd = data[2];

                        if (index < 0 ||  index > stops.Length ) 
                        {
                            Console.WriteLine(stops);
                            continue;
                        }

                       stops = stops.Insert(index, strToAdd);

                        break;

                    case "Remove Stop":

                        int startIndex = int.Parse(data[1]);
                        int endIndex = int.Parse(data[2]);

                        if (startIndex <0 || startIndex > stops.Length - 1
                            || endIndex < 0 || endIndex > stops.Length - 1 || endIndex<startIndex)
                        {
                            Console.WriteLine(stops);
                            continue;
                        }    

                       stops = stops.Remove(startIndex,endIndex - startIndex + 1);
                        break ;

                    case "Switch":
                        string oldString = data[1];
                        string newString = data[2];

                        if (stops.Contains(oldString))
                        {
                           stops =  stops.Replace(oldString, newString);
                        }
                        break ;
                }
                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }
    }
}
