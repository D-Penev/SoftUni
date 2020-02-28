namespace FootballTeam
{
    using System;
    using System.Linq;
    using System.Collections.
        Generic;

    public class Engine
    {
        static List<Team> teams = new List<Team>();
        public void Run()
        {
            

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine =="END")
                {
                    break;
                }

                string[] tokens = commandLine.Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentCommand = tokens[0];

                Team team;

                if (currentCommand == "Team")
                {
                    try
                    {
                        team = new Team(tokens[1]);
                        teams.Add(team);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }

                if (currentCommand == "Add")
                {
                    string teamName = tokens[1];

                    string playerName = tokens[2];

                    int endurance = int.Parse(tokens[3]);

                    int sprint = int.Parse(tokens[4]);

                    int dribble = int.Parse(tokens[5]);

                    int passing = int.Parse(tokens[6]);

                    int shooting = int.Parse(tokens[7]);

                    Player player;

                    try
                    {
                        

                        var teamToCheck = teams.FirstOrDefault(x => x.Name == teamName);
                        if (teamToCheck == null)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {

                            player = new Player(playerName, endurance, sprint, passing, dribble, shooting);

                            teamToCheck.AddPlayer(player);

                        }



                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }

                  
                }

                if (currentCommand == "Remove")
                {
                    string teamToCheck = tokens[1];

                    string playerName = tokens[2];

                    var teamToWorkWith = teams.FirstOrDefault(x => x.Name == teamToCheck);

                    if (teamToWorkWith!=null)
                    {
                        teamToWorkWith.RemovePlayer(playerName);
                    }
                    else
                    {
                        Console.WriteLine($"");
                    }
   

                }
                else if(currentCommand == "Rating")
                {
                    var currentTeam = tokens[1];


                    var toCheck = teams.FirstOrDefault(x => x.Name == currentTeam);

                    if (toCheck!=null)
                    {
                        Console.WriteLine(toCheck.Stats());
                    }
                    else
                    {
                        Console.WriteLine($"Team {currentTeam} does not exist.");
                    }
                }
                
            }

        }
       
    }
}