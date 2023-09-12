using System;
using Jarai.Patterns.Structural.Proxy;

namespace Proxy
{
    internal class Program
    {
        static void Main()
        {
            var db = new DatabaseServer();

            var proxy = new DatabaseAuthorizationProxy(db);

            // Keine Berechtigung...
            //var daten = proxy.GetData();

            proxy.Login("Admin");
            var daten = proxy.GetData();

            Console.WriteLine(daten);
        }
    }
}