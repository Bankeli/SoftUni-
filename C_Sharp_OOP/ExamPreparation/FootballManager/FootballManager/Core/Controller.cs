using FootballManager.Core.Contracts;
using FootballManager.Models;
using FootballManager.Models.Contracts;
using FootballManager.Repositories;
using FootballManager.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Core
{
    public class Controller : IController
    {
        private TeamRepository championship = new TeamRepository();

        public string ChampionshipRankings()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("***Ranking Table***");
            int counter = 1;
            foreach (Team team in championship.Models.OrderByDescending(t => t.ChampionshipPoints)
                .ThenByDescending(t => t.PresentCondition))
            {
                sb.AppendLine();
                sb.Append($"{counter}. {team}/{team.TeamManager}");

                counter++;
            }
            return sb.ToString();
        }

        public string JoinChampionship(string teamName)
        {
            if (championship.Models.Count == championship.Capacity)
                return OutputMessages.ChampionshipFull;
            else if (championship.Exists(teamName))
                return string.Format(OutputMessages.TeamWithSameNameExisting, teamName);
            else
            {
                ITeam team = new Team(teamName);
                championship.Add(team);
                return string.Format(OutputMessages.TeamSuccessfullyJoined, team.Name);
            }
        }

        public string MatchBetween(string teamOneName, string teamTwoName)
        {
            if (!championship.Exists(teamOneName) || !championship.Exists(teamTwoName))
                return OutputMessages.OneOfTheTeamDoesNotExist;

            ITeam firstTeam = championship.Get(teamOneName);
            ITeam secondTeam = championship.Get(teamTwoName);

            if (firstTeam.PresentCondition == secondTeam.PresentCondition)
            {
                firstTeam.GainPoints(1);
                secondTeam.GainPoints(1);
                return string.Format(OutputMessages.MatchIsDraw, firstTeam.Name, secondTeam.Name);
            }
            else
            {
                ITeam winner, loser;
                if (firstTeam.PresentCondition > secondTeam.PresentCondition)
                    (winner, loser) = (firstTeam, secondTeam);
                else
                    (winner, loser) = (secondTeam, firstTeam);

                winner.GainPoints(3);
                if (winner.TeamManager != null)
                    winner.TeamManager.RankingUpdate(5);
                if (loser.TeamManager != null)
                    loser.TeamManager.RankingUpdate(-5);

                return string.Format(OutputMessages.TeamWinsMatch, winner.Name, loser.Name);
            }



        }

        public string PromoteTeam(string droppingTeamName, string promotingTeamName, string managerTypeName, string managerName)
        {
            if (!championship.Exists(droppingTeamName))
                return string.Format(OutputMessages.DroppingTeamDoesNotExist, droppingTeamName);

            if (championship.Exists(promotingTeamName))
                return string.Format(OutputMessages.TeamWithSameNameExisting, promotingTeamName);

            ITeam team = new Team(promotingTeamName);
            IManager manager = CreateManager(managerTypeName, managerName);
            if (manager != null && !IsManagerTaken(managerName)) 
                team.SignWith(manager);

            foreach (ITeam teamToReset in championship.Models)
            {
                teamToReset.ResetPoints();
            }

            championship.Remove(droppingTeamName);
            championship.Add(team);

            return string.Format(OutputMessages.TeamHasBeenPromoted, team.Name);
        }

        public string SignManager(string teamName, string managerTypeName, string managerName)
        {
            if (!championship.Exists(teamName))
                return string.Format(OutputMessages.TeamDoesNotTakePart, teamName);

            if (managerTypeName != nameof(AmateurManager) && managerTypeName != nameof(SeniorManager)
                && managerTypeName != nameof(ProfessionalManager))
                return string.Format(OutputMessages.ManagerTypeNotPresented, managerTypeName);

            ITeam team = championship.Get(teamName);

            if (team.TeamManager != null)
                return string.Format(OutputMessages.TeamSignedWithAnotherManager, teamName, team.TeamManager.Name);

            if (IsManagerTaken(managerName))
                return string.Format(OutputMessages.ManagerAssignedToAnotherTeam, managerName);

            IManager manager = CreateManager(managerTypeName, managerName);
            
            team.SignWith(manager);

            return string.Format(OutputMessages.TeamSuccessfullySignedWithManager, team.TeamManager.Name, team.Name);
        }

        private IManager CreateManager(string managerTypeName, string managerName)
        {
            if (managerTypeName == nameof(AmateurManager))
                return new AmateurManager(managerName);
            else if (managerTypeName == nameof(SeniorManager))
                return new SeniorManager(managerName);
            else if (managerTypeName == nameof(ProfessionalManager))
                return new ProfessionalManager(managerName);
            else
                return null;

        }

        private bool IsManagerTaken(string managerName)
            => championship.Models.Any(t => t.TeamManager != null && t.TeamManager.Name == managerName);
    }
}
