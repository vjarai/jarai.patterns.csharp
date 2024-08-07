﻿namespace Jarai.Patterns.Creational.Prototype.DeepClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new Person
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
        }
    }
}
