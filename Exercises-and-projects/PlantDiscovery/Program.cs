namespace PlantDiscovery
{
    internal class Program
    {
        public class Plants
        {
            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<double> Rating { get; set; }

            public Plants(string name, int rarity)
            {
                Name = name;
                Rarity = rarity;
                Rating = new List<double>();
            }

            public double AverageRating => Rating.Count > 0 ? Rating.Average() : 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,Plants> plantsList = new Dictionary<string,Plants>();

            for (int i = 0; i < n; i++)
            {
                string[] plantData = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantData[0];
                int rarity = int.Parse(plantData[1]);

                if (!plantsList.ContainsKey(plantName))
                    {
                    plantsList[plantName] = new Plants(plantName, rarity);
                }
                else
                {
                    plantsList[plantName].Rarity = rarity;
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] plantData = input.Split(new[] { ": ", " - " }, StringSplitOptions.None);

                string action = plantData[0];
                string plants = plantData[1];

                if (!plantsList.ContainsKey(plants))
                {
                    Console.WriteLine("error");
                    continue;

                }
                switch (action)
                {
                    case "Rate":
                        double rating = double.Parse(plantData[2]);
                        plantsList[plants].Rating.Add(rating);
                        break;
                    case "Update":
                        int newRarity = int.Parse(plantData[2]);
                        plantsList[plants].Rarity = newRarity;
                        break;
                    case "Reset":
                        plantsList[plants].Rating.Clear();
                        break;
                        
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plantsList)
            {
                Console.WriteLine($"- {plant.Value.Name}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AverageRating:f2}");
            }
        }
    }
}

