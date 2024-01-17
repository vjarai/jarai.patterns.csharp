using System;

namespace Jarai.Patterns.Structural.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var b1 = new ApplePhone();

            var d1 = new LightningLadegerät();
            b1.Aufladen(d1);


            var p1 = new UsbLadegerät();
            var pa = new UsbToLightningAdapter(p1);
            b1.Aufladen(pa);

            Console.Read();
        }
    }
}