namespace FootballTeam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Team
    {
        private string name;

        private List<Player> players;

        public double Rating => CalculateAverageTeamStats();

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public List<Player> Players
        {
            get => this.players;
            private set
            {
                this.players = value;
            }
        }

        private double CalculateAverageTeamStats()
        {
            double averageTeamStats = 0d;

            if (this.Players.Count != 0)
            {
                averageTeamStats = this.Players.Average(x => x.OverallSkillLevel);
                return averageTeamStats;
            }
            return 0;
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }


       public void RemovePlayer(string playerName)
        {
            var playerToRemove = this.Players.FirstOrDefault(x => x.Name == playerName);

            if (playerToRemove!=null)
            {
                this.Players.Remove(playerToRemove);
            }
            else
            {
                Console.WriteLine($"Player {playerName} is not in {this.Name} team.");
            }
        }

       public string Stats()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}