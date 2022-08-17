using System;

namespace Refresher.Aggregation
{
    public class Rad
    {
        public Rad(int durchmesser)
        {
            Durchmesser = durchmesser;
        }

        public int Durchmesser { get; }

        public void Anzeigen()
        {
            Console.WriteLine("Raddurchmesser = {0}", Durchmesser);
        }
    }
}