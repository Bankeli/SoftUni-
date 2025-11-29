using FootballManager.Models.Contracts;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public abstract class Manager : IManager
    {
        private string name;
        private double ranking;

        private const double MaxRank = 100;
        private const double MinRank = 0;

        protected Manager(string name, double ranking)
        {
            Name = name;
            Ranking = ranking;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.ManagerNameNull);
                this.name = value;
            }
        }

        public double Ranking
        {
            get => this.ranking;
            protected set
            {
                if (value < MinRank)
                    this.ranking = MinRank;
                else if (value > MaxRank)
                    this.ranking = MaxRank;
                else
                    this.ranking = value;
            }
        }

        public abstract void RankingUpdate(double updateValue);

        public override string ToString()
            => $"{Name} - {this.GetType().Name} (Ranking: {Ranking:F2})";

    }
}
