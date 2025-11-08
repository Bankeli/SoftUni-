using RaidGroup.Core.Interfaces;
using RaidGroup.Factory;
using RaidGroup.Factory.Iterfaces;
using RaidGroup.IO.Interfaces;
using RaidGroup.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IHeroFactory factory;
        public Engine(IReader reader, IWriter writer, IHeroFactory factory)
        {
            this.reader = reader;
            this.writer = writer;
            this.factory = factory;
        }
        public void Run()
        {
            int heroCounter = int.Parse(reader.ReadLine());
            List<IHero> heroes = new List<IHero>();

            while (heroCounter > 0)
            {
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                try
                {
                    IHero hero = factory.CreateHero(type, name);
                    heroes.Add(hero);
                    heroCounter--;
                }
                catch (ArgumentException ex)
                {

                    writer.WriteLine(ex.Message);
                }
            }

            foreach (IHero hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
            }

            int raidPower = heroes.Sum(h => h.Power);
            int bossPower = int.Parse(reader.ReadLine());

            if (raidPower >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }
    }
}

