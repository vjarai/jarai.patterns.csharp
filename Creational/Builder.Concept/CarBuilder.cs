
namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Concrete builders implement steps defined in the common interface.
 */
    public class CarBuilder : IBuilder {
        private CarType _type;
        private int _seats;
        private Engine _engine;
        private Transmission _transmission;
        private TripComputer _tripComputer;
        private GpsNavigator _gpsNavigator;

        public void SetCarType(CarType type) {
            this._type = type;
        }

    
        public void SetSeats(int seats) {
            this._seats = seats;
        }

    
        public void SetEngine(Engine engine) {
            this._engine = engine;
        }

    
        public void SetTransmission(Transmission transmission) {
            this._transmission = transmission;
        }

    
        public void SetTripComputer(TripComputer tripComputer) {
            this._tripComputer = tripComputer;
        }

    
        public void SetGpsNavigator(GpsNavigator gpsNavigator) {
            this._gpsNavigator = gpsNavigator;
        }

        public Car GetResult() {
            return new Car(_type, _seats, _engine, _transmission, _tripComputer, _gpsNavigator);
        }
    }
}