namespace WildFarm
{
    using System;

    public class Hen : Bird
    {
        public Hen(string name,double weight,double wingSize
            ) : base(name,weight,wingSize)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(Food food)
        {
            double totalWeightGain = food.Quantity * 0.35;

            this.FoodEaten = food.Quantity;

            this.Weight += totalWeightGain;
        }
    }
}