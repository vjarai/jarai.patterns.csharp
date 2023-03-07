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
            var user = new User
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

            // Wait for user
            Console.ReadKey();
        }
    }
}