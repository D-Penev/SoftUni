namespace ExplicitInterfaces
{
    using System;

    using System.Linq;

    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            var listOfCitizens = new List<Citizen>();
            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "End")
                {
                    break;
                }

                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

                listOfCitizens.Add(citizen);

            }

            foreach (var citizen in listOfCitizens)
            {
                IPerson person = citizen;

                IResident resident = citizen;

                person.GetName();

                resident.GetName();
            }
        }
    }
}