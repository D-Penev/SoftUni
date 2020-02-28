namespace Vehicles
{
    using System;

    using System.Linq;

    using System.Collections.Generic;


    public class Engine
    {
        static List<Vehicle> listOfVehicles = new List<Vehicle>();

        public void Run()
        {
            string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

             Car car = GenerateCar(carData);

            string[] truckData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Truck truck = GenerateTruck(truckData);

            string[] busData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bus bus = GenerateBus(busData);

            int numberOfCommands = int.Parse(Console.ReadLine());

            CommandParser(numberOfCommands,car,truck,bus);

            listOfVehicles.Add(car);

            listOfVehicles.Add(truck);

            listOfVehicles.Add(bus);

            foreach (var vehicle in listOfVehicles)
            {
                Console.WriteLine(vehicle);
            }
            
        }

    

        private void CommandParser(int numberOfCommands, Car car, Truck truck, Bus bus)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentCommand = commandArgs[0];

                if (currentCommand == "Drive" || currentCommand == "DriveEmpty")
                {
                    string vehicleType = commandArgs[1];

                    double distanceToDrive = double.Parse(commandArgs[2]);

                    DriveMethod(currentCommand,vehicleType, distanceToDrive, car, truck, bus);
                }
                else if (currentCommand == "Refuel")
                {
                    string currentVehicle = commandArgs[1];

                    double amountToRefuel = double.Parse(commandArgs[2]);

                    RefuelMethod(currentVehicle, amountToRefuel, car, truck, bus);
                }
            }
        }

        private void DriveMethod(string currentCommand,string vehicleType, double distanceToDrive, Car car, Truck truck, Bus bus)
        {
            vehicleType = vehicleType.ToLower();

            if (currentCommand == "DriveEmpty")
            {
                bus.DriveEmpty(distanceToDrive);
            }
            else
            {
                switch (vehicleType)
                {
                    case "car":
                        car.Drive(distanceToDrive);
                        break;
                    case "truck":
                        truck.Drive(distanceToDrive);
                        break;
                    case "bus":
                        bus.Drive(distanceToDrive);
                        break;
                  
                }
            }
        }

        private void RefuelMethod(string currentVehicle, double amountToRefuel, Car car, Truck truck, Bus bus)
        {
            switch (currentVehicle.ToLower())
            {
                case "car":
                    car.Refuel(amountToRefuel);
                    break;
                case "truck":
                    truck.Refuel(amountToRefuel);
                    break;
                case "bus":
                    bus.Refuel(amountToRefuel);
                    break;
                
            }
        }

        public Car GenerateCar(string[] tokens)
        {
            double initialFuelQuantity = double.Parse(tokens[1]);

            double fuelConsumption = double.Parse(tokens[2]);

            int tankCapacity = int.Parse(tokens[3]);

            Car car = new Car(initialFuelQuantity, fuelConsumption, tankCapacity);

            return car;
        }

        public Truck GenerateTruck(string[] tokens)
        {
            double fuelQuantity = double.Parse(tokens[1]);

            double fuelConsumption = double.Parse(tokens[2]);

            int capacity = int.Parse(tokens[3]);

            Truck truck = new Truck(fuelQuantity, fuelConsumption, capacity);

            return truck;
        }

        public Bus GenerateBus(string[] tokens)
        {
            double fuelQuantity = double.Parse(tokens[1]);

            double fuelConsumption = double.Parse(tokens[2]);

            int capacity = int.Parse(tokens[3]);

            Bus bus = new Bus(fuelQuantity, fuelConsumption, capacity);

            return bus;
        }
       
    }
}
    
