namespace MilitaryElite
{
    using System;
    using System.Text;

    public class SpecializedSoldier : Private, ISpecializedSoldier
    {
        public string Corps { get; private set; }

        public SpecializedSoldier(string firstName,string lastName,int id,decimal salary,string corps)
            :base(firstName,lastName,id,salary)
        {
            this.Corps = corps;
        }

        public override string ToString()
        {
            var toPrint = new StringBuilder();

            toPrint.AppendLine($"{base.ToString()}")
                .Append($"Corps: {this.Corps}");
            return toPrint.ToString();
        }
    }
}