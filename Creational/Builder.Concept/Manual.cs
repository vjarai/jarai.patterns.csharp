

namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Car manual is another product. Note that it does not have the same ancestor
 * as a Car. They are not related.
 */
    public class Manual {
        private  CarType _carType;
        private  int _seats;
        private  Engine _engine;
        private  Transmission _transmission;
        private  TripComputer _tripComputer;
        private  GpsNavigator _gpsNavigator;

        public Manual(CarType carType, int seats, Engine engine, Transmission transmission,
            TripComputer tripComputer, GpsNavigator gpsNavigator) {
            this._carType = carType;
            this._seats = seats;
            this._engine = engine;
            this._transmission = transmission;
            this._tripComputer = tripComputer;
            this._gpsNavigator = gpsNavigator;
        }

        public string Print() {
            string info = "";
            info += "Type of car: " + _carType + "\n";
            info += "Count of seats: " + _seats + "\n";
            info += "Engine: volume - " + _engine.GetVolume() + "; mileage - " + _engine.GetMileage() + "\n";
            info += "Transmission: " + _transmission + "\n";
            if (this._tripComputer != null) {
                info += "Trip Computer: Functional" + "\n";
            } else {
                info += "Trip Computer: N/A" + "\n";
            }
            if (this._gpsNavigator != null) {
                info += "GPS Navigator: Functional" + "\n";
            } else {
                info += "GPS Navigator: N/A" + "\n";
            }
            return info;
        }
    }
}