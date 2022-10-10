using System;

namespace Jarai.Patterns.Creational.Prototype.ShallowClone
{
    public class User
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Address Address { get; set; }

        public User ShallowClone()
        {
            return new User()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Address = this.Address
            };
        }

    }
}