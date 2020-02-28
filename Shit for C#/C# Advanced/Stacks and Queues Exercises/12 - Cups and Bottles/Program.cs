using System;
using System.Collections.Generic;
using System.Linq;
namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main()
        {
            int[] cups = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var cupsStack = new Stack<int>();
            for (int i = cups.Length - 1; i >= 0; i--)
            {
                cupsStack.Push(cups[i]);
            }
            int[] bottles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bottlesStack = new Stack<int>();
            for (int i = 0; i < bottles.Length; i++)
            {
                bottlesStack.Push(bottles[i]);

            }
            int amountOfWastedWater = 0;
            while (bottlesStack.Count != 0 && cupsStack.Count != 0)
            {
                int currentCup = cupsStack.Pop();
                int currentBottle = bottlesStack.Pop();
                if (currentBottle >= currentCup)
                {
                    amountOfWastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;
                    cupsStack.Push(currentCup);
                }
            }
            if (cupsStack.Count == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottlesStack)}");
            }
            else
            {
                Console.WriteLine($"Cups: {String.Join(" ", cupsStack)}");
            }
            Console.WriteLine($"Wasted litters of water: {amountOfWastedWater}");
        }
    }
}
