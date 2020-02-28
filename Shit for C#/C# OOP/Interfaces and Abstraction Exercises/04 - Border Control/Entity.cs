namespace BorderControl
{
    using System;
    using System.Linq;
    
    public class Entity : ICheck
    {
       public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Entity(string name,string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public void CheckId(string toCheck,string idFromInput)
        {
            if (toCheck.EndsWith(idFromInput))
            {
                Console.WriteLine(toCheck);
            }
        }
    }
}