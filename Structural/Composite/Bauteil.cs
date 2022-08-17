using System;

namespace Jarai.Patterns.Structural.Compositum
{
    public class Bauteil
    {
        private readonly double _preis;
        protected string Name;

        public Bauteil(string name, double preis)
        {
            Name = name;
            _preis = preis;
        }

        public virtual double GetPreis()
        {
            Console.WriteLine("{0} ermittel seinen Preis!", Name);

            return _preis;
        }
    }
}