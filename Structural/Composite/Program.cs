using System;

namespace Jarai.Patterns.Structural.Compositum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var projekt = new Baugruppe("Projekt");

            var layer = new Baugruppe("Layer");
            projekt.Add(layer);

            var fließweg = new Baugruppe("Fließweg");
            layer.Add(fließweg);

            var teilstrecke = new Baugruppe("Teilstrecke");
            fließweg.Add(teilstrecke);

            var waschtisch = new Bauteil("Waschtisch", 100.0);
            teilstrecke.Add(waschtisch);

            var dusche = new Bauteil("Dusche", 200.0);
            teilstrecke.Add(dusche);

            Console.WriteLine("Das Projekt kostet {0:0.00} Euro", projekt.GetPreis());
            Console.Read();
        }
    }
}