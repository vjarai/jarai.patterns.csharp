

namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Unlike other creational patterns, Builder can construct unrelated products,
 * which don't have the common interface.
 * <p>
 * In this case we build a user manual for a car, using the same steps as we
 * built a car. This allows to produce manuals for specific car models,
 * configured with different features.
 */
    public class CarManualBuilder : IBuilder {
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

        public Manual GetResult() {
            return new Manual(_type, _seats, _engine, _transmission, _tripComputer, _gpsNavigator);
        }
    }
}