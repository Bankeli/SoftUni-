using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.Models
{
    public class Paladin : BaseHero
    {
        private const int PaladinPower = 100;
        public Paladin(string name)
            : base(name, PaladinPower)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    
    }
}
