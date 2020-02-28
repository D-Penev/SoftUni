namespace Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity,double fuelConsumption,int capacity
            ): base(fuelQuantity,fuelConsumption,capacity)
        {

        }


        private const double AIR_CON = 1.4d;

        public override void Drive(double distance)
        {
            double totalFuel = (this.FuelConsumption + AIR_CON) *distance;

            if (this.Fuel >= totalFuel)
            {
                this.Fuel -= totalFuel;
                Console.WriteLine($"Bus travelled { distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refuelling");
            }
        }

        public void DriveEmpty(double distance)
        {
            double totalFuel = distance * this.FuelConsumption;

            if (this.Fuel >= totalFuel)
            {
                this.Fuel -= totalFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
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
            return $"Bus: {this.Fuel:f2}";
        }
    }
}