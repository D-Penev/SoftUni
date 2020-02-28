namespace FootballTeam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Player
    {

        //endurance sprint passing dribble shoot
        private string name;

        private int endurance;

        private int sprint;

        private int passing;

        private int dribble;

        private int shoot;

        public Player(string name,int endurance,int sprint,int passing,int dribble,int shoot)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Passing = passing;
            this.Dribble = dribble;
            this.Shoot = shoot;
        }

        public double OverallSkillLevel => CalculateAveragePlayerStats();

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

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }
                this.passing = value;
            }
        }

       public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }

        public int Shoot
        {
            get => this.shoot;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shoot should be between 0 and 100.");
                }
                this.shoot = value;
            }
        }

        private double CalculateAveragePlayerStats()
        {
            double playerStats = 0d;

            playerStats = Math.Round((this.Endurance + this.Shoot + this.Dribble + this.Passing + this.Sprint)/5.0);
            return playerStats;
        }
    }
}