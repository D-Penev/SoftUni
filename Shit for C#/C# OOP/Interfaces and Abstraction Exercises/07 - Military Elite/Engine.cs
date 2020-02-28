namespace MilitaryElite
{
    using System;

    using System.Linq;

    using System.Collections.Generic;

    public class Engine
    {
        static List<ISoldier> listOfSoldiers = new List<ISoldier>();

        public void Run()
        {
            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "End")
                {
                    break;
                }

                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentSoldierType = tokens[0];

                if (currentSoldierType == "Private")
                {
                    GeneratePrivate(tokens);
                }
                else if(currentSoldierType == "Commando")
                {
                    GenerateCommando(tokens);
                }
                else if(currentSoldierType == "Engineer")
                {
                    GenerateEngineer(tokens);
                }
                else if(currentSoldierType == "Spy")
                {
                    GenerateSpy(tokens);
                }
                else if(currentSoldierType == "LieutenantGeneral")
                {
                    GenerateGeneral(tokens);
                }
            }

            foreach (var soldier in listOfSoldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private void GenerateGeneral(string[] tokens)
        {
            int[] privateId = tokens.Skip(5).Select(int.Parse).ToArray();

            var listOfPrivates = new List<ISoldier>();

            foreach (var id in privateId)
            {
                var toAdd = listOfSoldiers.FirstOrDefault(x => x.Id == id);

                listOfPrivates.Add(toAdd);
            }

            int generalId = int.Parse(tokens[1]);

            string firstName = tokens[2];

            string lastName = tokens[3];

            decimal salary = decimal.Parse(tokens[4]);

            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(firstName, lastName, generalId, salary, listOfPrivates);

            listOfSoldiers.Add(lieutenantGeneral);
        }

        private void GenerateSpy(string[] tokens)
        {
            int id = int.Parse(tokens[1]);

            string firstName = tokens[2];

            string lastName = tokens[3];

            int codeNumber = int.Parse(tokens[4]);

            ISpy spy = new Spy(firstName, lastName, id, codeNumber);

            listOfSoldiers.Add(spy);
        }

        private void GenerateEngineer(string[] tokens)
        {
            string corps = tokens[5];

            if (!CheckCorps(corps))
            {
                return;
            }
            else
            {
                int engineerId = int.Parse(tokens[1]);

                string firstName = tokens[2];

                string lastName = tokens[3];

                decimal salary = decimal.Parse(tokens[4]);



                var listOfRepairs = new List<IRepair>();

                for (int i = 6; i < tokens.Length; i += 2)
                {
                    string repairtPartName = tokens[i];

                    int repairtPartHours = int.Parse(tokens[i + 1]);

                    IRepair repair = new Repair(repairtPartName, repairtPartHours);

                    listOfRepairs.Add(repair);
                }

                IEngineer engineer = new Engineer(firstName, lastName, engineerId, salary, corps, listOfRepairs);

                listOfSoldiers.Add(engineer);
            }

            
        }

        //soldier generators
        private void GenerateCommando(string[] tokens)
        {
            string corps = tokens[5];

            if (!CheckCorps(corps))
            {
                return;
            }
            else
            {
                var listOfMissions = new List<IMission>();

                for (int i = 6; i < tokens.Length; i+=2)
                {
                    string missionStatus = tokens[i + 1];

                    if (!CheckMissionStatus(missionStatus))
                    {
                        continue;
                    }
                    else
                    {
                        IMission currentMission = new Mission(tokens[i], missionStatus);
                        listOfMissions.Add(currentMission);
                    }
                }

                int commandoId = int.Parse(tokens[1]);

                string commandoFirstName = tokens[2];

                string commandoLastName = tokens[3];

                decimal commandoSalary = decimal.Parse(tokens[4]);

                ICommando commando = new Commando(commandoFirstName, commandoLastName, commandoId,
                    commandoSalary, corps, listOfMissions);

                listOfSoldiers.Add(commando);
            }
        }

        private void GeneratePrivate(string[] tokens)
        {
            int privateId = int.Parse(tokens[1]);

            string privateFirstName = tokens[2];

            string privateLastName = tokens[3];

            decimal privateSalary = decimal.Parse(tokens[4]);

            IPrivate @private = new Private(privateFirstName, privateLastName, privateId, privateSalary);

            listOfSoldiers.Add(@private);
        }

        //Utility methods

        private static bool CheckMissionStatus(string mission)
        {
            if (mission != "inProgress" && mission != "Finished")
            {
                return false;
            }
            return true;
        }

        private static bool CheckCorps(string corps)
        {
            if (corps != "Airforces" && corps != "Marines")
            {
                return false;
            }

            return true;
        }
    }
}