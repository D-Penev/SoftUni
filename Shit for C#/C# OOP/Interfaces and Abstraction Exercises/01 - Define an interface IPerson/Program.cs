namespace PersonInfo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson currentPerson = new Citizen(name, age);
            Console.WriteLine(currentPerson.Age);
            Console.WriteLine(currentPerson.Name);
        }
    }
}