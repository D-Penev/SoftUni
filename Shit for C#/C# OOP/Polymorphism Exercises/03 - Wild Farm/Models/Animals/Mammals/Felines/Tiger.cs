namespace WildFarm
{
    using System;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion,breed)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                double totalWeightGained = food.Quantity * 1.0;

                this.FoodEaten = food.Quantity;

                this.Weight += totalWeightGained;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}