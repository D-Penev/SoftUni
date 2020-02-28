namespace PizzaCalories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Pizza
    {
        private string name;

        private List<Topping> toppings;

        private Dough dough;

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
            this.Dough = dough;
        }

        public double Calories
        {
            get => this.TotalCalories();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get => this.toppings;
            private set
            {
                if (value.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [1..10]");
                }
                this.toppings = value;
            }
        }
        public Dough Dough
        {
            get => this.dough;
            private set
            {
                this.dough = value;
            }
        }


        public double TotalCalories()
        {
            double total = 0d;

            foreach (var item in this.Toppings)
            {
                total += item.Calories;
            }
            total += this.Dough.Calories;
            return total;
        }

        public void AddTopping(Topping topping)
        {
            
            this.toppings.Add(topping);
        }


        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:f2} Calories.";
        }
    }
}