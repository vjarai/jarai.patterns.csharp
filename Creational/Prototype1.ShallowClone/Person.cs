using System;

namespace Jarai.Patterns.Creational.Prototype.ShallowClone
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person ShallowClone()
        {
            return new Person()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Address = this.Address
            };
        }

    }
}