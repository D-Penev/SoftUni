namespace WildFarm
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string name,double weight,string livingRegion)
            :base(name,weight,livingRegion)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                double totalWeightGained = food.Quantity * 0.10;

                this.Weight += totalWeightGained;

                this.FoodEaten = food.Quantity;
            }

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}