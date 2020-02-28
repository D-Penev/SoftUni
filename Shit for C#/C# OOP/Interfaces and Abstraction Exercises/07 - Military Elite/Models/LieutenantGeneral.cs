namespace MilitaryElite
{
    using System;

    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<ISoldier> Privates { get; private set; }

        public LieutenantGeneral(string firstName, string lastName, int id, decimal salary, List<ISoldier> privates)
            :base(firstName,lastName,id,salary)
        {
            this.Privates = privates;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");

            sb.AppendLine($"Privates:");

            foreach (var @private in this.Privates)
            {
                sb.AppendLine($" {@private.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}