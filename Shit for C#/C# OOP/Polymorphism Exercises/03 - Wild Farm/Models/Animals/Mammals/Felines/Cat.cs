namespace WildFarm
{
    using System;

    public class Cat : Feline
    {
        public Cat(string name,double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion,breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                double totalWeightGained = food.Quantity * 0.30;

                this.Weight += totalWeightGained;

                this.FoodEaten = food.Quantity;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}