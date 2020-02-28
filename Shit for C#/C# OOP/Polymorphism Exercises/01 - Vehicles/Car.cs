namespace Vehicles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Car : Vehicle
    {
        public Car(double fuel, double consumptipon) : base(fuel,consumptipon)
        {

        }
        private const double airconDependency = 0.9d;

        public override bool Drive(double distance)
        {
            var totalFuelRequired = (base.FuelConsumption + airconDependency) * distance;
            if (base.Fuel <= totalFuelRequired)
            {
                DisplayMessage();
                return false;
            }
            else
            {
                Console.WriteLine($"Car travelled {distance} km");
                base.Fuel -= totalFuelRequired;
                return true;
            }
            
            
        }
        public override void Refuel(double fuel)
        {
            base.Fuel += fuel;
        }
        public void DisplayMessage()
        {
            Console.WriteLine($"Car needs refueling");
        }
        public override string ToString()
        {
            return $"Car: {this.Fuel:f2}";
        }

    }
}