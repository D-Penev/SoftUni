namespace MilitaryElite
{
    using System;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(string firstName,string lastName,int id,int codeNumber)
            :base(firstName,lastName,id)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            var toPrint = new StringBuilder();

            toPrint.AppendLine($"{base.ToString()}")
                .Append($"Code Number: {this.CodeNumber}");
            return toPrint.ToString();
        }
    }
}