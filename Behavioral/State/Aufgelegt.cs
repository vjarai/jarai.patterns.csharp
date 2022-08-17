using System;

namespace Jarai.Patterns.Behavioral.State
{
    public class Aufgelegt : Zustand
    {
        public override Zustand Abheben()
        {
            Console.WriteLine("Telefon abgehoben :-)");
            return new Abgehoben();
        }

        public override Zustand Annehmen()
        {
            Console.WriteLine("Anruf angenommen :-)");
            return new Abgehoben();
        }
    }
}