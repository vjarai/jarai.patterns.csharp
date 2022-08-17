using System;

namespace Jarai.Patterns.Creational.FactoryMethod
{
    public class Tisch : Möbel
    {
        private readonly int _fläche;

        public Tisch(double preis, string name, int fläche) : base(preis, name)
        {
            _fläche = fläche;
        }

        public override void Anzeigen()
        {
            Console.WriteLine("Fläche {0}", _fläche);
            base.Anzeigen();
        }

        public override void Benutzen()
        {
            Console.WriteLine("TISCH wird benutzt!");
        }

        public override void Montieren()
        {
            IstMontiert = true;
        }
    }
}