using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_5.__Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int counter = 0;
            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum == capacity)
                {
                    stack.Pop();
                    counter++;
                    sum = 0;
                }
                else if (sum > capacity)
                {
                    counter++;
                    sum = 0;
                }
                else
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                counter = 1;
            }

            Console.WriteLine(counter);
        }
    }
}