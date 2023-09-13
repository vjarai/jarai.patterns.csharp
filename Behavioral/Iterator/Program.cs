using System;

namespace Jarai.Patterns.Behavioral.Iterator
{
    // Concrete Iterators implement various traversal algorithms. These classes
    // store the current traversal position at all times.

    // Concrete Collections provide one or several methods for retrieving fresh
    // iterator instances, compatible with the collection class.

    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
                Console.WriteLine(element);

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection) 
                Console.WriteLine(element);
        }
    }
}