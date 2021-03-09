using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    class Car
    {
        public enum FuelTypes
        {
            Petrol,
            Diesel
        }
        protected float fuelTankSize;
        protected float fuelGauge;
        protected FuelTypes fuelType;
        public float FuelTankSize
        {
            get
            {
                return fuelTankSize;
            }
            protected set
            {
                fuelTankSize = value;
            }
        }
        public float FuelGauge
        {
            get
            {
                return fuelGauge;
            }
            set
            {
                if (value > fuelTankSize) throw new Exception("Not enough space for specified amount of fuel!");
                fuelGauge = value;
            }
        }
        public FuelTypes FuelType
        {
            get
            {
                return fuelType;
            }
            protected set
            {
                fuelType = value;
            }
        }
        public void Refuel(FuelTypes fuelType, float fuelAmount)
        {
            if (fuelType != this.fuelType) throw new Exception("Tried to refuel the wrong type of fuel!");
            if (fuelAmount + fuelGauge > fuelTankSize) throw new Exception("Not enough space for specified amount of fuel!");
            fuelGauge += fuelAmount;
        }
    }
}
