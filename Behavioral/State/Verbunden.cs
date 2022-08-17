using System;

namespace Jarai.Patterns.Behavioral.State
{
    public class Verbunden : Zustand
    {
        public override Zustand Auflegen()
        {
            Console.WriteLine("Telefon aufgelegt :-)");
            return new Aufgelegt();
        }

        public override Zustand Sprechen()
        {
            Console.WriteLine("Es wird gesprochen :-)");
            return this;
        }
    }
}