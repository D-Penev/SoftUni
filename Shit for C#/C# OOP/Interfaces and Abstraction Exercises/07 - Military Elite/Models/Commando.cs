namespace MilitaryElite
{
    using System;

    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecializedSoldier, ICommando
    {
       public List<IMission> Missions { get; private set; }

       public Commando(string firstName,string lastName,int id,decimal salary,string corps,List<IMission> missions) 
            :base(firstName,lastName,id,salary,corps)
        {
            this.Missions = missions;
        }

        public override string ToString()
        {
            var toPrint = new StringBuilder();

            toPrint.AppendLine($"{base.ToString()}")
                 .AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                toPrint.AppendLine($"  {mission.ToString()}");
            }

            return toPrint.ToString().Trim();
        }
    }
}