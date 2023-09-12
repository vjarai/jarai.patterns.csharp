namespace Jarai.Patterns.Creational.Builder
{
    /**
 * Just another feature of a car.
 */
    public class GpsNavigator {
        private  string _route;

        public GpsNavigator() {
            this._route = "221b, Baker Street, London  to Scotland Yard, 8-10 Broadway, London";
        }

        public GpsNavigator(string manualRoute) {
            this._route = manualRoute;
        }

        public string GetRoute() {
            return _route;
        }
    }
}
