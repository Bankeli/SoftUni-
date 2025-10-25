using System.Reflection.Metadata.Ecma335;

namespace _03.Pirates
{
    internal class Program
    {
        public class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }

            public City(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, City> citiesMap = new Dictionary<string, City>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] citiesData = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = citiesData[0];
                int population = int.Parse(citiesData[1]);
                int gold = int.Parse(citiesData[2]);

                if (!citiesMap.ContainsKey(cityName))
                {
                    citiesMap.Add(cityName, new City(cityName));

                }
                citiesMap[cityName].Population += population;
                citiesMap[cityName].Gold += gold;
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] actionData = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = actionData[0];
                string cityName = actionData[1];

                switch (action)
                {
                    case "Plunder":
                        int people = int.Parse(actionData[2]);
                        int gold = int.Parse(actionData[3]);

                        PlunderTheCity(citiesMap, cityName, people, gold);

                        break;
                    case "Prosper":

                        bool isCityProsper = CityProsperity(citiesMap, actionData, cityName);
                        if (!isCityProsper)
                        {
                            continue;
                        }
                        break;
                }
            }

            if (citiesMap.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesMap.Count} wealthy settlements to go to:");

                foreach (var city in citiesMap.Values)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else 
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static bool CityProsperity(Dictionary<string, City> citiesMap, string[] actionData, string cityName)
        {
            int goldAmount = int.Parse(actionData[2]);
            if (goldAmount < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
                return false;
            }

            citiesMap[cityName].Gold += goldAmount;

            Console.WriteLine($"{goldAmount} gold added to the city treasury. {cityName} now has {citiesMap[cityName].Gold} gold.");
            return true;
        }

        private static void PlunderTheCity(Dictionary<string, City> citiesMap, string cityName, int people, int gold)
        {
            citiesMap[cityName].Population -= people;
            citiesMap[cityName].Gold -= gold;

            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

            if (citiesMap[cityName].Population <= 0 || citiesMap[cityName].Gold <= 0)
            {
                citiesMap.Remove(cityName);

                Console.WriteLine($"{cityName} has been wiped off the map!");
            }

        }
    }
}

       
    
