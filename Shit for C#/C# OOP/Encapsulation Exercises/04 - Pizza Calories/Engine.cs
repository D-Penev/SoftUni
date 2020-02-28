namespace PizzaCalories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Engine
    {
        

        public void Run()
        {
            string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                ReceieveInput(inputArgs);
            }
            catch (ArgumentException maikati)
            {
                Console.WriteLine(maikati.Message);
            }
        }

        public void ReceieveInput(string[] tokens)
        {
            if (tokens.Length == 1)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            string pizzaName = tokens[1];

            tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string doughType = tokens[1];

            string doughBaking = tokens[2];

            double doughWeight = double.Parse(tokens[3]);

            var currentDough = new Dough(doughType, doughBaking, doughWeight);

            var currentPizza = new Pizza(pizzaName, currentDough);

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "END")
                {
                    break;
                }
                string[] args = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = args[1];

                double weight = double.Parse(args[2]);

                var topping = new Topping(type, weight);

                if (currentPizza.Toppings.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");

                }

                currentPizza.AddTopping(topping);
            }
            Console.WriteLine(currentPizza);
        }
    }
}