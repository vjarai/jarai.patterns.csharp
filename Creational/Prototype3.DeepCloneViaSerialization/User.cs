using System;

namespace Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public User Clone()
        {
            return JsonSerializer.Clone(this);
        }

    }
}