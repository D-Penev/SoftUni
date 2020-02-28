namespace BorderControl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
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
                if (inputData.Length == 2)
                {
                    var entity = new Entity(inputData[0], inputData[1]);
                    listOfEntities.Add(entity);
                }
                else
                {
                    var entity = new Entity(inputData[0], inputData[2]);
                    listOfEntities.Add(entity);
                }
            }
            string idToCheck = Console.ReadLine();
            foreach (var entity in listOfEntities)
            {
                entity.CheckId(entity.Id, idToCheck);
            }
        }
    }
}