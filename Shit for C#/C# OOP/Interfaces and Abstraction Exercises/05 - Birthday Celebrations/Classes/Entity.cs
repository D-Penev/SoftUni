namespace BirthdayCelebrations.Classes
{
    using System;
    using System.Linq;
    using BirthdayCelebrations.Interfaces;
    using System.Collections.Generic;
    public class Entity : IBirthDate
    {
        
        public string BirthDate { get; set; }

        public Entity(string date)
        {
            this.BirthDate = date;
        }

        public bool CheckBirthDate(string inputData)
        {
            if (this.BirthDate.EndsWith(inputData))
            {
                Console.WriteLine(this.BirthDate);
               
            }
           
            return false;
        }
    }
}