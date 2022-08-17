using System;

namespace Jarai.Patterns.Creational.AbstractFactory
{
    public class Bauteil
    {
        public Bauteil(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public string Name { get; }
        public double Preis { get; }

        public virtual double GetPreis()
        {
            Console.WriteLine("{0} ermittel seinen Preis!", Name);
            return Preis;
        }
    }
}