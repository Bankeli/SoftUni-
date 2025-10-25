using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        public class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public decimal Damage { get; set; }
            public Demon(string name, int health, decimal damage)
            {
                Name = name;
                Health = health;
                Damage = damage;
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

            List<Demon> sortedDemons = new List<Demon>();

            foreach (string demonName in input)
            {
                int health = GetDemonHealth(demonName);

                decimal damage = GetDemonDamage(demonName);

                Demon newDemon = new Demon(demonName, health, damage);
                sortedDemons.Add(newDemon);
            }

            sortedDemons = sortedDemons.OrderBy(d => d.Name).ToList();

            foreach (var demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static decimal GetDemonDamage(string demonName)
        {
            decimal damage = 0;
            string damagePattern = @"-?\d+(\.\d+)?";
            string multiplyPattern = @"[\*\/]";
            foreach (Match match in Regex.Matches(demonName,damagePattern))
            {
                decimal number;
                decimal.TryParse(match.Value, out number);
                damage += number;
            }
            foreach (Match m in Regex.Matches(demonName, multiplyPattern))
            {
                switch (m.Value)
                {
                    case "*":
                        damage *= 2;
                        break;
                    case "/":
                        damage /= 2;
                        break;
                }
            }

            return damage;
        }

        private static int GetDemonHealth(string demonName)
        {
            int health = 0;
            string healthPattern = @"[^\d\+\-\*\/\.]";

            foreach (Match match in Regex.Matches(demonName, healthPattern))
            {
                health += match.Value[0];
            }

            return health;
        }


    }
}
