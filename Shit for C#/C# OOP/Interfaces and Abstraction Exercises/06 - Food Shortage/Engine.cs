namespace FoodShortage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    public class Engine
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            var listOfPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    Citizen citizen = GetCitizen(tokens);
                    listOfPeople.Add(citizen);
                }
                else if(tokens.Length == 3)
                {
                    Rebel rebel = GetRebel(tokens);
                    listOfPeople.Add(rebel);
                }

               
            }
            
            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "End")
                {
                    break;
                }


                if (listOfPeople.Any(x => x.Name == commandLine))
                {
                    listOfPeople.FirstOrDefault(x => x.Name == commandLine).BuyFood();
                }
            }

            int totalFood = 0;

            listOfPeople.ForEach(x => totalFood += x.Food);

            Console.WriteLine(totalFood);
        }

        private Citizen GetCitizen(string[] tokens)
        {
            return new Citizen(tokens[0], int.Parse(tokens[1]));
        }

        private Rebel GetRebel(string[] tokens)
        {
            return new Rebel(tokens[0], int.Parse(tokens[1]));
        }
    }
}