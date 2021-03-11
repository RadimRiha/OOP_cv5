using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    public class PassengerCar : Car
    {
        public int MaxPassengers { get; private set; }
        private int currentPassengers;

        public int CurrentPassengers
        {
            get
            {
                return currentPassengers;
            }
            set
            {
                if (value > MaxPassengers) throw new Exception("Not enough space for specified number of passengers!");
                currentPassengers = value;
            }
        }
        public PassengerCar(double fuelTankSize, FuelTypes fuelType, int maxPassengers)
        {
            this.FuelTankSize = fuelTankSize;
            this.FuelType = fuelType;
            this.MaxPassengers = maxPassengers;
            FuelGauge = 0;
            CurrentPassengers = 0;
        }
        public override string ToString()
        {
            return string.Format("Fuel tank size: {0}l\nCurrent fuel: {1}l\nFuel type: {2}\nMaximum passengers: {3}\nCurrent passengers: {4}\n", FuelTankSize, FuelGauge, FuelType, MaxPassengers, CurrentPassengers);
        }
    }
}
