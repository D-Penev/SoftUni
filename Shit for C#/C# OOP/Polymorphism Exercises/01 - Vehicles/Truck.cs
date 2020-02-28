namespace Vehicles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Truck : Vehicle
    {
        private const double airconUse = 1.6d;
        public Truck(double fuel,double fuelConsumption)  : base(fuel,fuelConsumption)
        {

        }


        public override bool Drive(double distance)
        {
            var totalFuelRequired = (base.FuelConsumption + airconUse) *distance;

            if (base.Fuel <= totalFuelRequired)
            {
                Console.WriteLine($"Truck needs refueling");
                return false;
            }
            else
            {
                base.Fuel -= totalFuelRequired;
                Console.WriteLine($"Truck travelled {distance} km");
                return true;
            }
        }
        public override void Refuel(double fuel)
        {
            base.Fuel += (fuel * 95 / 100);
        }

        public override string ToString()
        {
            return $"Truck: {this.Fuel:f2}";
        }
    }
}