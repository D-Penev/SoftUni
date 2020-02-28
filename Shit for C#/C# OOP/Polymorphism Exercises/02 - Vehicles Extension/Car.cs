namespace Vehicles
{
    using System;

    public class Car : Vehicle
    {
        private const double AIR_CON = 0.9d;

        public Car(double fuel,double fuelConsumption,int capacity) 
            :base(fuel,fuelConsumption,capacity)
        {

        }


        public override void Drive(double distance)
        {
            double requiredFuel = (this.FuelConsumption + AIR_CON) * distance;

            if (this.Fuel >= requiredFuel)
            {
                this.Fuel -= requiredFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refuelling");
            }


        }

        public override void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else
            {
                double totalFuel = this.Fuel + quantity;

                if (totalFuel > this.Capacity)
                {
                    Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                }
                else
                {
                    this.Fuel += quantity;
                    
                }
            }
        }

        public override string ToString()
        {
            return $"Car: {this.Fuel:f2}";
        }

    }
}