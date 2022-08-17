using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jarai.Patterns.Creational.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welche Fabrikt wollen Sie benutzen? ( 1 = Kemper, 2 = Geberit )");
            var eingabe = Console.ReadLine();

            AbstrakteFabrik fabrik = null;

            switch (eingabe)
            {
                case "2":
                    fabrik = new GeberitFabrik();
                    break;
                case "1":
                    fabrik = new KemperFabrik();
                    break;
                default:
                    Debug.Assert(false, "Keine Fabrik angelegt!");
                    break;
            }


            var projekt = new List<Bauteil>();

            var abzweig = fabrik.CreateAbzweig();
            var ventil = fabrik.CreateVentil();

            projekt.Add(abzweig);
            projekt.Add(ventil);

            foreach (var bauteil in projekt) Console.WriteLine($"{bauteil.Name} : {bauteil.Preis} EUR");

            Console.Read();
        }
    }
}