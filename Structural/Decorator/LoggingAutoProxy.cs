using System;

namespace Jarai.Patterns.Structural.Decorator
{
    public class LoggingAutoProxy : Auto
    {
        private readonly Auto _auto;

        public LoggingAutoProxy(Auto auto)
        {
            _auto = auto;
        }

        public override void Fahren(int strecke)
        {
            _auto.Fahren(strecke);

            Console.WriteLine("PROXY: Auto fährt {0} km.", strecke);
        }
    }
}