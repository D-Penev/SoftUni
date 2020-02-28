namespace MilitaryElite
{
    using System;

    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecializedSoldier, IEngineer
    {
        public List<IRepair> Repairs { get; private set; }

        public Engineer(string firstName,string lastName,int id, decimal salary,string corps,List<IRepair> repairs)
            :base(firstName,lastName,id,salary,corps)
        {
            this.Repairs = repairs;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}")
                .AppendLine($"Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}