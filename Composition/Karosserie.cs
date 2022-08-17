using System;

namespace Refresher.Aggregation
{
    public struct Karosserie
    {
        private readonly string _farbe;

        public Karosserie(string farbe)
        {
            _farbe = farbe;
        }

        public void Anzeigen()
        {
            Console.WriteLine("- Farbe: {0}", _farbe);
        }
    }
}