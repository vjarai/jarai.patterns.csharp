using System;

namespace Jarai.Patterns.Structural.Proxy
{
    internal class Program
    {
        static void Main()
        {
            var db = new Database();

            var proxy = new DatabaseAuthorizationProxy(db);

            // Keine Berechtigung...
            //var daten = proxy.GetData();

            proxy.Login("Admin");
            var daten = proxy.GetData();

            Console.WriteLine(daten);
        }
    }
}