namespace PizzaCalories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Topping
    {
        private string type;

        private double weight;


        public double Calories
        {
            get
            {
                return this.CalculateToppingCalories();
            }
        }

        public Topping(string type,double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce" && value.ToLower() != "meat")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double CalculateToppingCalories()
        {
            double type = GetTypeModifier();
            double totalCalories = ((this.Weight*2)*type);

            return totalCalories;
        }

        public double GetTypeModifier()
        {

            double typeFilter = 0d;

            switch (this.Type.ToLower())
            {
                case "meat":
                    typeFilter = 1.2d;
                    break;
                case "veggies":
                    typeFilter = 0.8d;
                    break;
                case "cheese":
                    typeFilter = 1.1d;
                    break;
                case "sauce":
                    typeFilter = 0.9d;
                    break;
                default:
                    break;
            }
            return typeFilter;
        }

    }
}