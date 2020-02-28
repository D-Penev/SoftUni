namespace Telephony
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Phone : IBrowseable, IPhone
    {
      public void Call(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    Console.WriteLine($"Invalid number!");
                    return;
                }
               
            }
            Console.WriteLine($"Calling... {number}");
            
        }
      public void Browse(string link)
        {
            for (int i = 0; i < link.Length; i++)
            {
                if (char.IsDigit(link[i]))
                {
                    Console.WriteLine($"Invalid URL!");
                    return;
                }
                
            }
            Console.WriteLine($"Browsing: {link}!");
            
        }
    }
}