using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    class Lorry : Car
    {
        private int maxCargo;
        private int currentCargo;
        public int MaxCargo
        {
            get
            {
                return maxCargo;
            }
            private set
            {
                maxCargo = value;
            }
        }
        public int CurrentCargo
        {
            get
            {
                return currentCargo;
            }
            private set
            {
                if (value > maxCargo) throw new Exception("Not enough space for specified amount of cargo!");
                currentCargo = value;
            }
        }
        public Lorry(float fuelTankSize, FuelTypes fuelType, int maxCargo)
        {
            this.fuelTankSize = fuelTankSize;
            this.fuelType = fuelType;
            this.maxCargo = maxCargo;
            fuelGauge = 0;
            currentCargo = 0;
        }
    }
}
