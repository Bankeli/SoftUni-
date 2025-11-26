using FootballManager.Models.Contracts;
using FootballManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Repositories
{
    public class TeamRepository : IRepository<ITeam>
    {

        private readonly List<ITeam> teams;
        private const int MaxCapacity = 10;

        public TeamRepository()
        {
            teams = new List<ITeam>();
        }
        public IReadOnlyCollection<ITeam> Models => teams.AsReadOnly();

        public int Capacity { get; } = MaxCapacity;

        public void Add(ITeam model)
        {
            if (teams.Count <  Capacity) this.teams.Add(model);
        }

        public bool Exists(string name)
        {
           return teams.Any(t => t.Name == name);
        }

        public ITeam Get(string name)
        {
            return teams.FirstOrDefault(t => t.Name == name);
        }

        public bool Remove(string name)
        {
           return teams.RemoveAll(t => t.Name == name) > 0;
        }
    }
}
