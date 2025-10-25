using System.Reflection.Metadata.Ecma335;
using static HeroesOfCodeAndLogic.Program;

namespace HeroesOfCodeAndLogic
{
    internal class Program
    {
        public class Hero
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int MP { get; set; }
            public Hero(string name, int hp, int mp)
            {
                Name = name;
                HP = RecieveHealth(hp);
                MP = RecieveMana(mp);
            }

            public int RecieveHealth(int health)
            {
                int recievedHealth = Math.Min(health, 100 - HP);
                HP += recievedHealth;
                return recievedHealth;
            }

            public int RecieveMana(int mana)
            {
                int recievedMana = Math.Min(mana, 200 - MP);
                MP += recievedMana;
                return recievedMana;
            }
            public override string ToString()
            {
                string battleResult = $"{Name}\n  HP: {HP}\n  MP: {MP}";
                return battleResult;
            }
        }
           public static Dictionary<string, Hero> Party = new Dictionary<string, Hero>();
        static void Main(string[] args)
        {
            int heroCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < heroCount; i++)
            {
                string[] heroArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroArg[0];
                int heroHP = int.Parse(heroArg[1]);
                int heroMP = int.Parse(heroArg[2]);

                Hero newHero = new Hero(heroName, heroHP, heroMP);
                Party.Add(heroName, newHero);
            }
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] actionData = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string action = actionData[0];
                string heroName = actionData[1];

                switch (action)
                {
                    case "CastSpell":
                        CastSpell(heroName, int.Parse(actionData[2]),actionData[3]);
                        break;

                    case "TakeDamage":
                        DamageResult(heroName, int.Parse(actionData[2]), actionData[3]);
                        break;

                    case "Recharge":
                        RechargeMana(heroName, int.Parse(actionData[2]));
                        break;

                    case "Heal":
                        Heal(heroName, int.Parse(actionData[2]));
                        break;
                }
            }

            foreach (var hero in Party.Values)
            {
                Console.WriteLine(hero);
            }
        }


        private static void CastSpell(string heroName, int mana, string spellName)
        {
            if (Party[heroName].MP >= mana)
            {
                Party[heroName].MP -= mana;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {Party[heroName].MP} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
        private static void DamageResult(string heroName, int damage, string attacker)
        {
            
            Party[heroName].HP -= damage;
            if (Party[heroName].HP > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {Party[heroName].HP} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                Party.Remove(heroName);
            }
        }
        private static void RechargeMana(string heroName, int mana)
        {
           int rechargedMP = Party[heroName].RecieveMana(mana);
            Console.WriteLine($"{heroName} recharged for {rechargedMP} MP!");
        }
        private static void Heal(string heroName, int hpAmount)
        {
           int recoveredHP = Party[heroName].RecieveHealth(hpAmount);
            Console.WriteLine($"{heroName} healed for {recoveredHP} HP!");
        }
    }
}
