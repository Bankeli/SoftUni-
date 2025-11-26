using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class AmateurManager : Manager
    {
        private const double InitialRank = 15;
        private const double RankingMultyplier = 0.75;
       
        public AmateurManager(string name)
            : base(name, InitialRank)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            Ranking += updateValue * RankingMultyplier;
        }
    }
}
