/*
 9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsaw
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai
 */

int totalEntries = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> map = new();
for (int i = 0; i < totalEntries; i++)
{
    var entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    var continent = entry[0];
    var country = entry[1];
    var city = entry[2];

    if (!map.ContainsKey(continent))
    {
        map[continent] = new Dictionary<string, List<string>>();
    }
    if (!map[continent].ContainsKey(country))
    {
    map[continent].Add(country, new List<string>());

    }
        map[continent][country].Add(city);

}

foreach (var (continentName, countryName) in map)
{
    Console.WriteLine($"{continentName}:");

    foreach (var (countries, cityName) in countryName)
    {
        Console.WriteLine($"  {countries} -> {string.Join(", ", cityName)}");
    }
}