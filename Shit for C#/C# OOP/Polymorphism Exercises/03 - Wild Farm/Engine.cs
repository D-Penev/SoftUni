namespace WildFarm
{
    using System;

    using System.Linq;

    using System.Collections.Generic;


    public class Engine
    {
       

        public void Run()
        {
            string commandLine = Console.ReadLine();

            var listOfAnimals = new List<Animal>();

            var listOfFoods = new List<Food>();

            while (commandLine != "End")
            {
                string[] animalData = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string[] foodData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var animalFactory = new AnimalFactory();

                Animal animal = animalFactory.GetAnimal(animalData);

                var foodFactory = new FoodFactory();

                Food food = foodFactory.GetFood(foodData);

                listOfAnimals.Add(animal);

                listOfFoods.Add(food);

                commandLine = Console.ReadLine();
            }

            AnimalsMakeSoundAndEat(listOfFoods, listOfAnimals);

            PrintAnimals(listOfAnimals);
            
        }

        public void AnimalsMakeSoundAndEat(List<Food> foods, List<Animal> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].ProduceSound();
                animals[i].EatFood(foods[i]);
            }
        }

        public void PrintAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}