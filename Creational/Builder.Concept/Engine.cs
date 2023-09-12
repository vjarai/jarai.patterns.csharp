

using System;

namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Just another feature of a car.
 */
    public class Engine {
        private  double _volume;
        private double _mileage;
        private bool _started;

        public Engine(double volume, double mileage) {
            this._volume = volume;
            this._mileage = mileage;
        }

        public void On() {
            _started = true;
        }

        public void Off() {
            _started = false;
        }

        public bool IsStarted() {
            return _started;
        }

        public void Go(double mileage) {
            if (_started) {
                this._mileage += mileage;
            } else {
                Console.WriteLine("Cannot go(), you must start engine first!");
            }
        }

        public double GetVolume() {
            return _volume;
        }

        public double GetMileage() {
            return _mileage;
        }
    }
}


