namespace TruckStop
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class TruckStop
    {
        static void Main()
        {
            int numberOfStations = Int32.Parse(Console.ReadLine());
            var station = new Queue<int[]>();
            for (int i = 0; i < numberOfStations; i++)
            {
                station.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }
            for (int index = 0; index < numberOfStations; index++)
            {
                if (isValidStation(numberOfStations, station))
                {
                    Console.WriteLine(index);
                    break;
                }
                //fix for station count being < 0
                var current = station.Dequeue();
                station.Enqueue(current);
            }
        }
        static bool isValidStation(int n, Queue<int[]> stek)
        {
            int currentFuel = 0;
            bool isValid = true;
            for (int i = 0; i < n; i++)
            {
                int[] currentStation = stek.Dequeue();
                int fuelGiven = currentStation[0];
                int distanceToNext = currentStation[1];
                currentFuel += fuelGiven - distanceToNext;
                if (currentFuel < 0)
                {
                    isValid = false;
                }
                stek.Enqueue(currentStation);
            }
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}