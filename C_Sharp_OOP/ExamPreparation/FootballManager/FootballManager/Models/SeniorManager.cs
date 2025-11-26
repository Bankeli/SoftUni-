using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class SeniorManager : Manager
    {

        private const double InitialRank = 30;
        public SeniorManager(string name)
        : base(name, InitialRank)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            Ranking += updateValue;
        }
    }
}
