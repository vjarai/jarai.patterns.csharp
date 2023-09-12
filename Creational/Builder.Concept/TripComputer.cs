
using System;

namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Just another feature of a car.
 */
    public class TripComputer {

        private Car _car;

        public void SetCar(Car car) {
            this._car = car;
        }

        public void ShowFuelLevel() {
            Console.WriteLine("Fuel level: " + _car.GetFuel());
        }

        public void ShowStatus() {
            if (this._car.GetEngine().IsStarted()) {
                Console.WriteLine("Car is started");
            } else {
                Console.WriteLine("Car isn't started");
            }
        }
    }
}
