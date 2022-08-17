using System;

namespace Refresher.Aggregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meinAuto = new Kfz("Porsche", 250, "Rot");

            meinAuto.Anzeigen();


            Console.Read();
        }
    }
}