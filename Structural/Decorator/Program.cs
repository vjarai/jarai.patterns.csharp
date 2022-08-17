using System;

namespace Jarai.Patterns.Structural.Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var originalAuto = new Auto();

            Auto autoProxy = new LoggingAutoProxy(originalAuto);

            autoProxy.Fahren(100);
            autoProxy.Fahren(222);

            originalAuto.StreckeAusgeben();

            Console.Read();
        }
    }
}