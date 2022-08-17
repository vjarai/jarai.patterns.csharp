using System;

namespace Jarai.Patterns.Creational.Singelton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meinHighlander = Highlander.GetInstance();
            var deinHighlander = Highlander.GetInstance();

            if (meinHighlander == deinHighlander)
                Console.WriteLine("Welt ist in Ordnung");
            else
                Console.WriteLine("Es kann nur einen geben... :-(");

            Console.Read();
        }
    }
}