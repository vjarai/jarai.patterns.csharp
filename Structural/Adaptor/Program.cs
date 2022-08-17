using System;

namespace Jarai.Patterns.Structural.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var b1 = new Brief("Sehr geehrter Herr XY, ...");

            var d1 = new Drucker();
            b1.Ausdrucken(d1);


            var p1 = new Plotter();
            var pa = new PlotterAdapter(p1);
            b1.Ausdrucken(pa);

            Console.Read();
        }
    }
}