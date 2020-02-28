namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BirthdayCelebrations.Classes;
    using BirthdayCelebrations.Interfaces;

    public class StartUp
    {
        static void Main()
        {
            var listOfEntities = new List<Entity>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "End")
                {
                    break;
                }
                string[] inputData = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputData.Length == 3 && inputData[0].Equals("Robot"))
                {
                    continue;
                }
                else if(inputData.Length == 5 && inputData[0].Equals("Citizen"))
                {
                    var entity = new Entity(inputData[4]);
                    listOfEntities.Add(entity);
                }
                else if(inputData.Length == 3 && inputData[0].Equals("Pet"))
                {
                    var entity = new Entity(inputData[2]);
                    listOfEntities.Add(entity);
                }
            }
            string toCheck = Console.ReadLine();
            foreach (var item in listOfEntities)
            {
                item.CheckBirthDate(toCheck);
              
                
            }
            
        }
    }
}