using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv5
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar car1 = new PassengerCar(10, Car.FuelTypes.Petrol, 5);
            Lorry car2 = new Lorry(20, Car.FuelTypes.Diesel, 50);

            car1.Refuel(Car.FuelTypes.Diesel, 5);
        }
    }
}
