namespace Vehicles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            string[] carInputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Car car = new Car(double.Parse(carInputData[1]), double.Parse(carInputData[2]));
            string[] truckInputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Truck truck = new Truck(double.Parse(truckInputData[1]), double.Parse(truckInputData[2]));
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandLine = tokens[0];
                if (commandLine.Equals("Drive"))
                {
                    string objectToDrive = tokens[1];
                    if (objectToDrive.Equals("Car"))
                    {
                        double distanceToDrive = double.Parse(tokens[2]);
                        car.Drive(distanceToDrive);
                    }
                    else
                    {
                        double distance = double.Parse(tokens[2]);
                        truck.Drive(distance);
                    }
                }
                if (commandLine.Equals("Refuel"))
                {
                    string vehicleToRefuel = tokens[1];
                    if (vehicleToRefuel.Equals("Car"))
                    {
                        double amount = double.Parse(tokens[2]);
                        car.Refuel(amount);
                    }
                    else
                    {
                        double amountToRefuel = double.Parse(tokens[2]);
                        truck.Refuel(amountToRefuel);
                    }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}