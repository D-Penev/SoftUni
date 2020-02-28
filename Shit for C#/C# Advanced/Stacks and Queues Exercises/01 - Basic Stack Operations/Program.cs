using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sequenceOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int numbersToPush = numbers[0];
            int numberToPop = numbers[1];
            int numbersToCheck = numbers[2];
            for (int i = 0; i <= numbersToPush && i < sequenceOfNumbers.Length; i++)
            {
                stack.Push(sequenceOfNumbers[i]);
            }
            for (int i = 0; i < numberToPop && stack.Count > 0; i++)
            {
                stack.Pop();
            }
            if (stack.Count > 0 && stack.Contains(numbersToCheck))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0 && !stack.Contains(numbersToCheck))
            {
                Console.WriteLine(stack.Min());
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}