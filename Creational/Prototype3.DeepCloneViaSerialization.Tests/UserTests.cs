using Xunit;
using Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarai.Patterns.Creational.Prototype.DeepCloneViaSerialization.Tests
{
    public class UserTests
    {
        [Fact()]
        public void Changing_clone_names_does_not_change_original_name()
        {
            // Arrange
            var orignal = new User { FirstName = "Donald", LastName = "Duck", Address = new Address { Street = "Erpelweg", City = "Entenhausen", Country = "Disneyland" } };
            var clone = orignal.Clone();

            // Act
            clone.FirstName = "Dagobert";
            clone.LastName = "Ente";

            // Assert
            Assert.Equal("Donald", orignal.FirstName);
            Assert.Equal("Duck", orignal.LastName);
        }


        [Fact()]
        public void Changing_clone_adress_does_not_change_original_adress()
        {
            // Arrange
            var orignal = new User { FirstName = "Donald", LastName = "Duck", Address = new Address { Street = "Erpelweg", City = "Entenhausen", Country = "Disneyland" } };
            var clone = orignal.Clone();

            // Act
            clone.Address.City = "Frankfurt";

            // Assert
            Assert.Equal("Entenhausen", orignal.Address.City);
        }
    }
}