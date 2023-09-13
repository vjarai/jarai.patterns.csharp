using System;

namespace Jarai.Patterns.Creational.Prototype.DeepClone
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

       

        public User DeepClone()
        {
            return new User()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Address = this.Address.DeepClone()
            };
        }


    }
}