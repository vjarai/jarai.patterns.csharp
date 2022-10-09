namespace Jarai.Patterns.Structural.Proxy
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>

    public class MathProxy : IMath
    {
        private readonly Math _math;

        public MathProxy(Math math)
        {
            _math = math;
        }

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}