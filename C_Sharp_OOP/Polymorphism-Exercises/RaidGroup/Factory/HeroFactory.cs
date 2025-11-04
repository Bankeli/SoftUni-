using RaidGroup.Factory.Iterfaces;
using RaidGroup.Models;
using RaidGroup.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.Factory
{
    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(string heroType, string name)
        {
            switch (heroType)
            {
                case "Druid":
                    return new Druid(name);

                case "Paladin":
                    return new Paladin(name);

                    case "Rogue":
                    return new Rogue(name);
                    case "Warrior":
                    return new Warrior(name);
                    default:
                    throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
