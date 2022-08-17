using System;

namespace Refresher.Inheritance
{
    public abstract class Kfz
    {
        private readonly string _marke;

        public Kfz(string marke)
        {
            _marke = marke;
        }

        public virtual void Anzeigen()
        {
            Console.WriteLine("Marke: {0}", _marke);
        }

        public virtual void Fahren()
        {
            Console.WriteLine("KFZ fährt!");
        }
    }
}