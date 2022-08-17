using System;

namespace Jarai.Patterns.Creational.FactoryMethod
{
    public class Ikea
    {
        private readonly string _standort;

        public Ikea(string standort)
        {
            _standort = standort;
        }

        /// <summary>
        ///     Fabrikmethode, erstellt unterschiedliche Arten von Möbeln
        /// </summary>
        public Möbel ProduziereMöbel(string artikelName)
        {
            Möbel neuesMöbel;

            switch (artikelName)
            {
                case "1":
                    neuesMöbel = new Tisch(100.0, "Sven", 1);
                    break;

                case "2":
                    neuesMöbel = new Stuhl(120.0, "Jörg", 2);
                    break;

                default:
                    throw new Exception($"Artikel {artikelName} ist nicht im Sortiment.");
            }

            return neuesMöbel;
        }
    }
}