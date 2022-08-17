using System;
using System.Collections.Generic;

namespace Jarai.Patterns.Structural.Compositum
{
    public class Baugruppe : Bauteil
    {
        private readonly List<Bauteil> _bauteile = new List<Bauteil>();

        public Baugruppe(string name) : base(name, 0.0)
        {
        }

        public void Add(Bauteil bauteil)
        {
            _bauteile.Add(bauteil);
        }

        public override double GetPreis()
        {
            var preis = 0.0;

            foreach (var bauteil in _bauteile)
                preis += bauteil.GetPreis();

            Console.WriteLine("{0} ermittel seinen Preis!", Name);

            return preis;
        }
    }
}