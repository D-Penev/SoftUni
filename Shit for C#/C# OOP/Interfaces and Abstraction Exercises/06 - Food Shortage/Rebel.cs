namespace FoodShortage
{
    using System;

    public class Rebel : Person
    {
        public Rebel(string name,int age) : base(name,
            age)
        {
            this.Food = 0;
        }


        public override void BuyFood()
        {
            this.Food += 5; 
        }

    }
}