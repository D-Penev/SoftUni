namespace Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuel,double fuelConsumption,int capacity
            ) : base(fuel,fuelConsumption,capacity)
        {

        }

        private const double AIR_CON = 1.6;

        private const int percentage = 95;

        public override void Drive(double distance)
        {
            double totalFuel = (this.FuelConsumption + AIR_CON) * distance;

            if (this.Fuel >= totalFuel)
            {
                this.Fuel -= totalFuel;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
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
            return $"Truck: {this.Fuel:f2}";
        }
    }
}