using System;

namespace Jarai.Patterns.Creational.FactoryMethod
{
    public abstract class Möbel
    {
        private readonly string _name;
        protected bool IstMontiert;

        public Möbel(double preis, string name)
        {
            Preis = preis;
            _name = name;
            IstMontiert = false;
        }

        public double Preis { get; }

        public virtual void Anzeigen()
        {
            Console.WriteLine("Preis: {0:0.00}", Preis);
            Console.WriteLine("Name : {0}", _name);
            Console.WriteLine("Montiert: {0}", IstMontiert ? "JA" : "NEIN");
        }

        public abstract void Benutzen();

        public abstract void Montieren();

        ~Möbel()
        {
            // ACHTUNG: Der Destruktor wird vom GarbageCollector aus einem anderen
            // Thread aufgerufen! Also auf Threadsicherheit achten

            Console.WriteLine("{0} verschrottet..", _name);
        }
    }
}