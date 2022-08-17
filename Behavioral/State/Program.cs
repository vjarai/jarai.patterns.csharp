using System;

namespace Jarai.Patterns.Behavioral.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var telefon = new Telefon();

            telefon.Sprechen();

            telefon.Abheben();
            telefon.Wählen();
            telefon.Wählen();
            telefon.Sprechen();
            telefon.Sprechen();
            telefon.Sprechen();
            telefon.Auflegen();
            telefon.Auflegen();


            Console.Read();
        }
    }
}