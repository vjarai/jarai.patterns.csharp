using System;

namespace Jarai.Patterns.Creational.FactoryMethod
{
    public class Stuhl : Möbel
    {
        private readonly int _höhe;

        public Stuhl(double preis, string name, int höhe)
            : base(preis, name)
        {
            _höhe = höhe;
        }

        public override void Anzeigen()
        {
            Console.WriteLine("Höhe {0}", _höhe);
            base.Anzeigen();
        }

        public override void Benutzen()
        {
            Console.WriteLine("Stuhl wird benutzt!");
        }

        public override void Montieren()
        {
            IstMontiert = true;
        }
    }
}