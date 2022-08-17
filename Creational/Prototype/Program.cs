using System;

namespace Jarai.Patterns.Creational.Prototype
{
    /// <summary>
    ///     Prototype Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create two instances and clone each
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }
    }
}