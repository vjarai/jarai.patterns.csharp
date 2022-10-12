﻿using System;
using System.Threading;

namespace Jarai.CSharp.Generic.LazyLoad
{
    internal class Program
    {
        /// <summary>
        /// Wird "Lazy" aufgerufen, wenn zum ersten mal auf x.Value zugegriffen wird.
        /// </summary>
        private static int SlowCalculation()
        {
            Console.WriteLine("Der Wert wird nur beim ersten Zugriff geladen/berechnet.");
            Thread.Sleep(1000); // simuliert eine langsame Berechnung
            return 42;
        }

        private static void Main(string[] args)
        {
            var x = new Lazy<int>(SlowCalculation); // SlowCalculation wird hier noch nicht aufgerufen!

            var eingabe = Console.ReadLine();

            if (eingabe != "skip")
            {
                Console.WriteLine(x.Value);  // Berechnet den x.Value durch Aufruf von SlowCalculation
                Console.WriteLine(x.Value);  // Verwendet den bereits berechneten Wert ("Cache")
            }
        }
    }
}