using System;

namespace Jarai.Patterns.Behavioral.Observer
{
    internal class Program
    {
        private static void Main()
        {
            var boerse = new Aktie();

            var beobachter1 = new Beobachter();

            var beobachter2 = new Beobachter();

            boerse.AddBeobachter(beobachter1);
            boerse.AddBeobachter(beobachter2);

            boerse.Kurs = 5000;
            boerse.Kurs = 6000;

            boerse.RemoveBeobachter(beobachter2);

            boerse.Kurs = 4000;

            Console.Read();
        }
    }
}