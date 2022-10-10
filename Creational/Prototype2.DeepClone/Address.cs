using System;

namespace Jarai.Patterns.Creational.Prototype.DeepClone
{
    public class Address
    {
        public String Street { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

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