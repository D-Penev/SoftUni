namespace MilitaryElite
{
    using System;
    using System.Text;

    public class Mission : IMission
    {
        public string CodeName { get; private set; }

        public string Status { get; private set; }

        public Mission(string codeName,string status)
        {
            this.CodeName = codeName;
            this.Status = status;
        }

        public void CompleteMission()
        {
            this.Status = "Finished"; 
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.Status}";
        }
    }
}