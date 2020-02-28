namespace MilitaryElite
{
    using System;
    using System.Text;

    public class Private : Soldier,IPrivate
    {
        public decimal Salary { get; private set; }

        public Private(string firstName,string lastName,int id,decimal salary)
            :base(firstName,lastName,id)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:f2}";
        }
    }
}