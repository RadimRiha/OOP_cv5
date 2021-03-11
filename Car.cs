using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    abstract public class Car
    {
        public enum FuelTypes
        {
            Petrol,
            Diesel
        }
        public double FuelTankSize { get; protected set; }
        protected double fuelGauge;
        public FuelTypes FuelType { get; protected set; }
        public CarRadio Radio = new CarRadio();

        public double FuelGauge
        {
            get
            {
                return fuelGauge;
            }
            set
            {
                if (value > FuelTankSize) throw new Exception("Not enough space for specified amount of fuel!");
                fuelGauge = value;
            }
        }
        public void Refuel(FuelTypes fuelType, double fuelAmount)
        {
            if (fuelType != this.FuelType) throw new Exception("Tried to refuel the wrong type of fuel!");
            if (fuelAmount + FuelGauge > FuelTankSize) throw new Exception("Not enough space for specified amount of fuel!");
            FuelGauge += fuelAmount;
        }
    }
}
