using System;

namespace Jarai.Patterns.Behavioral.ObserverWithEvents
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var q = new Datenquelle("DAX");

            var b1 = new Beobachter("Anleger1");
            var b2 = new Beobachter("Anleger2");

            q.WertChanged += b1.WertPerMail;
            q.WertChanged += b2.WertPerSms;

            q.Wert = 5;
            q.Wert = 8;

            Console.ReadLine();
        }
    }
}