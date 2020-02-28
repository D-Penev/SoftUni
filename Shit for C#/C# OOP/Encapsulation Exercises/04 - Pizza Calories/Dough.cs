namespace PizzaCalories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Dough
    {

        

        private string flourType;

        private string bakingTechnique;

        private double weight;

        public double Calories
        {
            get { return this.CalculateCalories(); }
        }

        public Dough(string flour,string technique,double weight)
        {
            this.FlourType = flour;
            this.BakingTechnique = technique;
            this.Weight = weight;
        }
       
        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;

            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value.ToLower() != "chewy" && value.ToLower() != "crispy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException($"Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

       public double CalculateCalories()
        {
            

            double flourModifier = GetFlourType();

            double bakingTechniqueModifier = GetTechniqueType();

            var totalCalories = (((this.Weight * 2) * flourModifier) * bakingTechniqueModifier);

            return totalCalories;
        }


        public double GetFlourType()
        {
            double flourModifier = 0;
            switch (this.FlourType.ToLower())
            {
                case "white":
                    flourModifier = 1.5d;
                    break;
                case "wholegrain":
                    flourModifier = 1.0d;
                    break;
                default:
                    break;
            }
            return flourModifier;
        }

        public double GetTechniqueType()
        {
            double techniqueModifier = 0;
            switch (this.BakingTechnique.ToLower())
            {
                case "chewy":
                    techniqueModifier = 1.1d;
                    break;
                case "crispy":
                    techniqueModifier = 0.9d;
                    break;
                case "homemade":
                    techniqueModifier = 1.0d;
                    break;
                default:
                    break;
            }
            return techniqueModifier;
        }
    }
}