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

            Console.WriteLine("Car 1 status\n" + car1.ToString());
            Console.WriteLine("Car 2 status\n" + car2.ToString());

            Console.WriteLine("Refueling, adding cargo and passengers...");

            try { car1.Refuel(Car.FuelTypes.Petrol, 5); }
            catch (Exception e) 
            { 
                Console.WriteLine(e);
                return;
            }
            try { car2.Refuel(Car.FuelTypes.Diesel, 5); }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            try { car1.CurrentPassengers = 3; }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            try { car2.CurrentCargo = 50; }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Car 1 status\n" + car1.ToString());
            Console.WriteLine("Car 2 status\n" + car2.ToString());

            Console.WriteLine("Testing car 1 radio...\n");
            Console.WriteLine(car1.Radio.ToString());

            Console.WriteLine("Adding presets and turning on...\n");
            car1.Radio.SetPreset(0, 80);
            car1.Radio.SetPreset(0, 90);
            car1.Radio.SetPreset(1, 100);
            car1.Radio.RadioOn = true;
            try { car1.Radio.TuneToPreset(1); }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            Console.WriteLine(car1.Radio.ToString());
        }
    }
}
