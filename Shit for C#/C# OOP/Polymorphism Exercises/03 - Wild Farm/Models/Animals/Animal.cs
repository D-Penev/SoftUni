namespace WildFarm
{
    using System;

    public abstract class Animal
    {
        private string name;

        private double weight;

        private int foodEaten;

        public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
           
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public double Weight
        {
            get => this.weight;
            protected set => this.weight = value;
        }

        public int FoodEaten
        {
            get => this.foodEaten;
            protected set => this.foodEaten = value;
        }

        public abstract void ProduceSound();

        public abstract void EatFood(Food food);

        
    }
}