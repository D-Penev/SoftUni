namespace PersonInfo
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string personName = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IBirthable birthable = new Citizen(personName, personAge, id, birthdate);
            IIdentifiable identiable = new Citizen(personName, personAge, id, birthdate);
            Console.WriteLine(identiable.Id);
            Console.WriteLine(birthable.Birthdate);

        }
    }
}