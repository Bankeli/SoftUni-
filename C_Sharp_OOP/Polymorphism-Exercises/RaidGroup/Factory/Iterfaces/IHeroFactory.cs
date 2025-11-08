using RaidGroup.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.Factory.Iterfaces
{
    public interface IHeroFactory
    {
        IHero CreateHero(string heroType, string name);
    }
}
