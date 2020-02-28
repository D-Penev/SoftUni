namespace Vehicles
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public abstract class Vehicle
    {
        private double fuel;

        private double fuelConsumption;

        private int capacity;

        public Vehicle(double fuel,double fuelConsumption,int capacity)
        {
            if (fuel > capacity)
            {
                this.Fuel = 0;
            }
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
        }


        public double Fuel
        {
            get => this.fuel;
            set => this.fuel = value;
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public int Capacity
        {
            get => this.capacity;
            private set => this.capacity = value;
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double quantity);
    }
}