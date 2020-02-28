namespace WildFarm
{
    using System;

    public class Owl : Bird
    {
        public Owl(string name,double weight,double wingSize
            ): base(name,weight,wingSize)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void EatFood(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");

            }
            else
            {
                double totalWeightGained = food.Quantity * 0.25;

                this.Weight += totalWeightGained;

                this.FoodEaten = food.Quantity;
            }
        }
    }
}