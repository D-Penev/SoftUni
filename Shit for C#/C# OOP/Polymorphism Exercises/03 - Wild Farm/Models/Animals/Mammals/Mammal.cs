namespace WildFarm
{
    using System;

    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight,string livingRegion)
            :base(name,weight)
        {
            this.LivingRegion = livingRegion;
        }

        private string livingRegion;

        public string LivingRegion
        {
            get => this.livingRegion;
            private set => this.livingRegion = value;
        }
    }
}