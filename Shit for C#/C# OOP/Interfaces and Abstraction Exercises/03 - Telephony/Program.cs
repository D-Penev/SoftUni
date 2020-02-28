namespace Telephony
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                Phone phone = new Phone();
                phone.Call(phoneNumbers[i]);
            }
            string[] urlLinks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (urlLinks.Length == 0)
            {
                Console.WriteLine($"Browsing: !");
            }
            for (int i = 0; i < urlLinks.Length; i++)
            {
                Phone phone = new Phone();
                phone.Browse(urlLinks[i]);
            }
        }
    }
}