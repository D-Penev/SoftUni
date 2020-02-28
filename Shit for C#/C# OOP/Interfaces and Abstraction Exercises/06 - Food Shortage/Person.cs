namespace FoodShortage
{
    using System;

    public abstract class Person : IBuyer
    {
        private string name;

        private int age;

        public int Food { get;set; }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }

        public virtual void BuyFood()
        {
            
        }
    }
}