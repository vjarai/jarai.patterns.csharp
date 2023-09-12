
namespace Jarai.Patterns.Creational.Builder
{
    public class Car {
        private  CarType _carType;
        private  int _seats;
        private  Engine _engine;
        private  Transmission _transmission;
        private  TripComputer _tripComputer;
        private  GpsNavigator _gpsNavigator;
        private double _fuel = 0;

        public Car(CarType carType, int seats, Engine engine, Transmission transmission,
            TripComputer tripComputer, GpsNavigator gpsNavigator) {
            this._carType = carType;
            this._seats = seats;
            this._engine = engine;
            this._transmission = transmission;
            this._tripComputer = tripComputer;
            if (this._tripComputer != null) {
                this._tripComputer.SetCar(this);
            }
            this._gpsNavigator = gpsNavigator;
        }

        public CarType GetCarType() {
            return _carType;
        }

        public double GetFuel() {
            return _fuel;
        }

        public void SetFuel(double fuel) {
            this._fuel = fuel;
        }

        public int GetSeats() {
            return _seats;
        }

        public Engine GetEngine() {
            return _engine;
        }

        public Transmission GetTransmission() {
            return _transmission;
        }

        public TripComputer GetTripComputer() {
            return _tripComputer;
        }

        public GpsNavigator GetGpsNavigator() {
            return _gpsNavigator;
        }
    }
}
