namespace Jarai.Patterns.Creational.Singelton
{
    public class Highlander
    {
        private static Highlander _instance;

        private Highlander()
        {
        }

        public static Highlander GetInstance()
        {
            if (_instance == null)
                _instance = new Highlander();

            return _instance;
        }
    }
}