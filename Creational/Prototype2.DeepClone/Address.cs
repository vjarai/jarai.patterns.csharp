using System;

namespace Jarai.Patterns.Creational.Prototype.DeepClone
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address DeepClone()
        {
            return new Address()
            {
                City = this.City,
                Street = this.Street,
                Country = this.Country
            };
        }

    }
}