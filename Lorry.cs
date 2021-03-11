using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    public class Lorry : Car
    {
        public int MaxCargo { get; private set; }
        private int currentCargo;

        public int CurrentCargo
        {
            get
            {
                return currentCargo;
            }
            set
            {
                if (value > MaxCargo) throw new Exception("Not enough space for specified amount of cargo!");
                currentCargo = value;
            }
        }
        public Lorry(double fuelTankSize, FuelTypes fuelType, int maxCargo)
        {
            this.FuelTankSize = fuelTankSize;
            this.FuelType = fuelType;
            this.MaxCargo = maxCargo;
            FuelGauge = 0;
            CurrentCargo = 0;
        }
        public override string ToString()
        {
            return string.Format("Fuel tank size: {0}l\nCurrent fuel: {1}l\nFuel type: {2}\nMaximum cargo: {3}kg\nCurrent cargo: {4}kg\n", FuelTankSize, this.FuelGauge, FuelType, MaxCargo, this.CurrentCargo);
        }
    }
}
