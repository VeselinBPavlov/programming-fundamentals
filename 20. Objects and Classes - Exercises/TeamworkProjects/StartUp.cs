namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var clubs = CreateClubs();

            var invalidClubs = clubs.Where(x => x.TeamMembers.Count == 0).ToList();
            var validClubs = clubs.Where(x => x.TeamMembers.Count > 0).ToList();

            PrintValidClubs(validClubs);
            PrintInvalidClubs(invalidClubs);
        }

        public static void PrintInvalidClubs(List<Team> invalidClubs)
        {
            Console.WriteLine($"Teams to disband:");
            foreach (var team in invalidClubs.OrderBy(x => x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }

        public static void PrintValidClubs(List<Team> validClubs)
        {
            foreach (var team in validClubs.OrderByDescending(x => x.TeamMembers.Count).ThenBy(y => y.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        public static List<Team> CreateClubs()
        {
            var numOfTeams = int.Parse(Console.ReadLine());
            var clubs = new List<Team>();

            for (int i = 0; i < numOfTeams; i++)
            {
                var teamData = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var teamCreator = teamData[0];
                var teamName = teamData[1];
                var isTeamCreated = false;
                var isCreatorExisted = false;

                for (int j = 0; j < clubs.Count; j++)
                {
                    if (clubs[j].TeamName == teamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        isTeamCreated = true;
                        break;
                    }
                }
                if (!isTeamCreated)
                {
                    for (int j = 0; j < clubs.Count; j++)
                    {
                        if (clubs[j].CreatorName == teamCreator)
                        {
                            Console.WriteLine($"{teamCreator} cannot create another team!");
                            isCreatorExisted = true;
                            break;
                        }
                    }
                }
                
                if (!isTeamCreated && !isCreatorExisted)
                {
                    var currentTeam = new Team()
                    {
                        TeamName = teamName,
                        CreatorName = teamCreator,
                        TeamMembers = new List<string>()
                    };

                    clubs.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }

            var membersToJoin = Console.ReadLine();

            while (membersToJoin != "end of assignment")
            {
                var memberData = membersToJoin
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var memberName = memberData[0];
                var teamToJoin = memberData[1];
                var isTeamExisting = false;
                var isMemberExisting = false;

                for (int i = 0; i < clubs.Count; i++)
                {
                    if (clubs[i].TeamName == teamToJoin)
                    {
                        isTeamExisting = true;
                    }
                }

                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    membersToJoin = Console.ReadLine();
                    continue;
                }
                else
                {
                    for (int i = 0; i < clubs.Count; i++)
                    {
                        if (clubs[i].TeamMembers.Contains(memberName) || clubs[i].CreatorName == memberName)
                        {
                            isMemberExisting = true;
                        }
                    }
                }

                if (isMemberExisting)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else
                {
                    for (int i = 0; i < clubs.Count; i++)
                    {
                        if (clubs[i].TeamName == teamToJoin)
                        {
                            clubs[i].TeamMembers.Add(memberName);
                        }
                    }
                }

                membersToJoin = Console.ReadLine();
            }

            return clubs;
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> TeamMembers { get; set; }
    }
}
