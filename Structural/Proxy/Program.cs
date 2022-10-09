using System;

namespace Jarai.Patterns.Structural.Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create math proxy

            var mathProxy = new MathProxy(new Math());

            // Do the math

            Console.WriteLine("4 + 2 = " + mathProxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + mathProxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + mathProxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + mathProxy.Div(4, 2));

            // Wait for user

            Console.ReadKey();
        }
    }
}