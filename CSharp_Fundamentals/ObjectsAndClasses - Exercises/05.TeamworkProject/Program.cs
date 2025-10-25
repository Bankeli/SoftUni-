namespace _05.TeamworkProject
{
    internal class Program
    {
        public class Team
        {
            public Team(string name, string creator)
            {
                Name = name;
                Creator = creator;
                Members = new List<string>();
            }
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
            public override string ToString()
            {
                return $"{Name}\n" +
                       $"- {Creator}\n" +
                       $"{GetMembersString()}";
            }

            private string GetMembersString()
            {
                Members = Members
                    .OrderBy(name => name)
                    .ToList();

                string result = "";
                for (int i = 0; i < Members.Count - 1; i++)
                {
                    result += $"-- {Members[i]}\n";
                }

                result += $"-- {Members[Members.Count - 1]}";
                return result;
            }
        }
        static void Main(string[] args)
        {
            List<Team> teamLists = new List<Team>();

            int numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                string[] teamData = Console.ReadLine().Split("-");
                string creator = teamData[0];
                string name = teamData[1];

                Team team = new Team(name, creator);

                Team sameTeam = teamLists.Find(team => team.Name == name);
                Team sameCreator = teamLists.Find(t => t.Creator == creator);

                if (sameTeam != null)
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                    continue;
                }

                if (sameCreator != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }

                teamLists.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string joiner = arguments[0];
                string teamName = arguments[1];

                if (!teamLists.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teamLists.Any(t => t.Creator == joiner) ||
                    teamLists.Any(t => t.Members.Contains(joiner)))
                {
                    Console.WriteLine($"Member {joiner} cannot join team {teamName}!");
                    continue;
                }

                teamLists.Find(t => t.Name == teamName). Members.Add(joiner);
            }

            List<Team> leftTeams = teamLists.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandTeams = teamLists.Where(t => t.Members.Count == 0).ToList();

            List<Team> orderedTeams = leftTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            orderedTeams.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Teams to disband:");

            orderedTeams = disbandTeams.OrderBy(x => x.Name).ToList();
            orderedTeams.ForEach (t => Console.WriteLine(t.Name));
        }
    }
}
