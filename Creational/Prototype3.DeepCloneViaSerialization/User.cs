using System;

namespace Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization
{
    public class User
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Address Address { get; set; }

        public User Clone()
        {
            return JsonSerializer.Clone(this);
        }

    }
}