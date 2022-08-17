using System;

namespace Jarai.Patterns.Creational.FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ikea1 = new Ikea("Frankfurt");

            Console.WriteLine("Was möchten Sie kaufen? (1=Tisch, 2=Stuhl)");
            var artikelName = Console.ReadLine();

            var meinMöbel = ikea1.ProduziereMöbel(artikelName);

            meinMöbel.Montieren();
            meinMöbel.Benutzen();
            meinMöbel.Anzeigen();

            Console.ReadLine();
        }
    }
}