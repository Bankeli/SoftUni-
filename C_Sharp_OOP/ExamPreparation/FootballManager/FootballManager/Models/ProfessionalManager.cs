using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class ProfessionalManager : Manager
    {
        private const double InitialRank = 60;
        private const double RankingMultyplier = 1.5;
        public ProfessionalManager(string name)
            : base(name, InitialRank)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            Ranking += updateValue * RankingMultyplier;
        }
    }
}
