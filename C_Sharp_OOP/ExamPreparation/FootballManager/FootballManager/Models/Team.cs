using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class Team : ITeam
    {
        private string name;
        public Team(string name)
        {
          Name = name;  
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                name = value;
            }
        }

        public int ChampionshipPoints { get; private set; }

        public IManager TeamManager { get; private set; }

        public int PresentCondition
        {
            get
            {
                if (TeamManager == null)
                    return ChampionshipPoints;

                double result;
                if (ChampionshipPoints == 0) result = TeamManager.Ranking;
                else result = ChampionshipPoints * TeamManager.Ranking;

                return (int)Math.Floor(result);
               
            }
        }

        public override string ToString()
        => $"Team: {Name} Points: {ChampionshipPoints}";

        public void GainPoints(int points)
        {
           ChampionshipPoints += points;
        }

        public void ResetPoints()
        {
            ChampionshipPoints = 0;
        }

        public void SignWith(IManager manager)
        {
           TeamManager = manager;
        }
    }
}
