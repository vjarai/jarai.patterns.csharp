
namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Builder interface defines all possible ways to configure a product.
 */
    public interface IBuilder {
        void SetCarType(CarType type);

        void SetSeats(int seats);

        void SetEngine(Engine engine);

        void SetTransmission(Transmission transmission);

        void SetTripComputer(TripComputer tripComputer);

        void SetGpsNavigator(GpsNavigator gpsNavigator);
    }
}