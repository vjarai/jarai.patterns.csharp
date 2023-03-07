namespace Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization
{
    internal class Program
    {
        static void Main(string[] args)
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

            var userClone = JsonSerializer.Clone(user);
        }
    }
}
