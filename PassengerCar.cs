using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    class PassengerCar : Car
    {
        private int maxPassengers;
        private int currentPassengers;
        public int MaxPassengers
        {
            get
            {
                return maxPassengers;
            }
            private set
            {
                maxPassengers = value;
            }
        }
        public int CurrentPassengers
        {
            get
            {
                return currentPassengers;
            }
            set
            {
                if (value > maxPassengers) throw new Exception("Not enough space for specified number of passengers!");
                currentPassengers = value;
            }
        }
        public PassengerCar(float fuelTankSize, FuelTypes fuelType, int maxPassengers)
        {
            this.fuelTankSize = fuelTankSize;
            this.fuelType = fuelType;
            this.maxPassengers = maxPassengers;
            fuelGauge = 0;
            currentPassengers = 0;
        }
    }
}
