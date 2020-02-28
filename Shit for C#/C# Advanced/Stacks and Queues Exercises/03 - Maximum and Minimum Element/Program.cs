using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = Int32.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int actualCommand = int.Parse(commands[0]);
                if (actualCommand == 1)
                {
                    int elementToPush = int.Parse(commands[1]);
                    stack.Push(elementToPush);
                }
                if (actualCommand == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                if (actualCommand == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                if (actualCommand == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            var toPrint = stack.ToArray();
            int loopCounter = 0;
            foreach (var element in toPrint)
            {
                loopCounter++;
                int lengthCount = toPrint.Length;
                if (loopCounter < lengthCount)
                {
                    Console.Write(element + ", ");
                }
                else
                {
                    Console.Write(element);
                }
            }
        }
    }
}