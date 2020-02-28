namespace MilitaryElite
{
    using System;
    using System.Text;

    public class Soldier : ISoldier
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }

        public Soldier(string firstName,string lastName,int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}