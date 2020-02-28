namespace Vehicles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Vehicle
    {
        public Vehicle(double fuel,double consumption)
        {
            this.Fuel = fuel;
            this.FuelConsumption = consumption;
        }
        public double Fuel { get; set; }

        public double FuelConsumption { get; set; }


        public abstract bool Drive(double distance);

        public abstract void Refuel(double fuel);
       

    }
}