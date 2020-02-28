using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            int addLength = inputs[0];
            int removeLength = inputs[1];
            int check = inputs[2];
            for (int i = 0; i <= addLength && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; queue.Count > 0 && i < removeLength; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            if (queue.Contains(check))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}