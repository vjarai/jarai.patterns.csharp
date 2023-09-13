using System;

namespace Jarai.Patterns.Creational.Prototype.ShallowClone
{
    /// <summary>
    ///     Prototype Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Person
            {
                FirstName = "Fritz",
                LastName = "Fröhlich",
                Address = new Address
                {
                    City = "Frankfurt",
                    Street = "Teststrasse",
                    Country = "DE"
                }
            };

            var person2 = person1.ShallowClone();

            // Wait for user
            Console.ReadKey();
        }
    }
}