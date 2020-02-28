namespace FoodShortage
{
    using System;

    public class Citizen : Person
    {
        public Citizen(string name,int age) : base(name,age)
        {
            
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }

    }
}