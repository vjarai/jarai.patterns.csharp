using System;

namespace Jarai.Patterns.Behavioral.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var boerse = new Boerse();

            var p1 = new Person();

            var f1 = new Firma();

            boerse.AddBeobachter(p1);
            boerse.AddBeobachter(f1);

            boerse.Kurs = 5000;
            boerse.Kurs = 6000;

            boerse.RemoveBeobachter(f1);

            boerse.Kurs = 4000;

            Console.Read();
        }
    }
}