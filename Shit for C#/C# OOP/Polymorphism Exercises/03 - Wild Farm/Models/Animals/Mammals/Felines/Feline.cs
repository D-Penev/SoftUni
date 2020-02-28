namespace WildFarm
{
    using System;

    public abstract class Feline : Mammal
    {
        private string breed;

        public Feline(string name,double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get => this.breed; private set => this.breed = value; }
    }
}