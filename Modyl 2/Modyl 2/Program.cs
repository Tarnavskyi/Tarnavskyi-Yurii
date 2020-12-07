using System;

namespace Modyl_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player> {
    new Player { Name = "Alex", Team = "A", Score = 10 },
    new Player { Name = "Anna", Team = "A", Score = 20 },
    new Player { Name = "Luke", Team = "L", Score = 60 },
    new Player { Name = "Lucy", Team = "L", Score = 40 },
};

            var teamTotalScores =
                from player in players
                group player by player.Team into playerGroup
                select new
                {
                    Team = playerGroup.Key,
                    TotalScore = playerGroup.Sum(x => x.Score),
                };

            // teamTotalScores is collection of anonymous objects:
            // { Team = "A", TotalScore = 30 }
            // { Team = "L", TotalScore = 100 }
        }
    }
}
