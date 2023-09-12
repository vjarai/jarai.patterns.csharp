
namespace Jarai.Patterns.Creational.Builder
{
    public class Director {

        public void ConstructSportsCar(IBuilder builder) {
            builder.SetCarType(CarType.SportsCar);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(3.0, 0));
            builder.SetTransmission(Transmission.SemiAutomatic);
            builder.SetTripComputer(new TripComputer());
            builder.SetGpsNavigator(new GpsNavigator());
        }

        public void ConstructCityCar(IBuilder builder) {
            builder.SetCarType(CarType.CityCar);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(1.2, 0));
            builder.SetTransmission(Transmission.Automatic);
            builder.SetTripComputer(new TripComputer());
            builder.SetGpsNavigator(new GpsNavigator());
        }

        public void ConstructSuv(IBuilder builder) {
            builder.SetCarType(CarType.Suv);
            builder.SetSeats(4);
            builder.SetEngine(new Engine(2.5, 0));
            builder.SetTransmission(Transmission.Manual);
            builder.SetGpsNavigator(new GpsNavigator());
        }
    }
}