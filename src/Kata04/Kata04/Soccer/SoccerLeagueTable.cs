using System.Collections.Generic;
using System.IO;

namespace CodeKata.Kata04.Soccer
{
    public static class SoccerLeagueTable
    {
        private static readonly string Seperator = new('-', 21 - 7);

        public static List<Record> ParseData()
        {
            var fileContent = File.ReadAllLines("Soccer/football.dat");

            var soccerData = new List<Record>();

            // Skip first line
            for (int i = 1; i < fileContent.Length; i++)
            {
                // Get line
                var line = fileContent[i];

                // Skip if empty
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var teamName = line[7..21].Trim();

                // Eliminate '------' line
                if (teamName == Seperator)
                {
                    continue;
                }

                // Using @ notation here, een though usually I try to avoid it
                // Alternative names could be "forTeam", "againstTeam"

                var againstOpponent = int.Parse(line[43..45]);
                var forOpponent = int.Parse(line[50..52]);

                soccerData.Add(new Record(teamName, againstOpponent, forOpponent));
            }

            return soccerData;
        }

        public static string GetNameOfTeamWithSmallestGoalDifference(IList<Record> soccerData)
        {
            Record lowestDifference = soccerData[0];
            for (int i = 1; i < soccerData.Count; i++)
            {
                if(lowestDifference.Difference < soccerData[i].Difference)
                {
                    lowestDifference = soccerData[i];
                }
            }

            return lowestDifference.Name;
        }
    }
}
