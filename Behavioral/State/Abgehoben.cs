using System;

namespace Jarai.Patterns.Behavioral.State
{
    public class Abgehoben : Zustand
    {
        public override Zustand Auflegen()
        {
            Console.WriteLine("Es wird aufgelegt :-)");
            return new Aufgelegt();
        }

        public override Zustand Wählen()
        {
            Console.WriteLine("Es wird gewählt :-)");
            return new Verbunden();
        }
    }
}