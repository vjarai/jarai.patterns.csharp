﻿using Xunit;
using Jarai.Patterns.Creational.Prototype.ShallowClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarai.Patterns.Creational.Prototype.ShallowClone.Tests
{
    public class UserTests
    {
        [Fact()]
        public void Changing_clone_names_does_not_change_original_name()
        {
            // Arrange
            var orignal = new User { FirstName = "Donald", LastName = "Duck", Address = new Address { Street = "Erpelweg", City = "Entenhausen", Country = "Disneyland" } };
            var clone = orignal.ShallowClone();

            // Act
            clone.FirstName = "Dagobert";
            clone.LastName = "Ente";

            // Assert
            Assert.Equal("Donald", orignal.FirstName);
            Assert.Equal("Duck", orignal.LastName);
        }


        [Fact()]
        public void Changing_clone_adress_changes_original_adress()
        {
            // Arrange
            var orignal = new User { FirstName = "Donald", LastName = "Duck", Address = new Address { Street = "Erpelweg", City = "Entenhausen", Country = "Disneyland" } };
            var clone = orignal.ShallowClone();

            // Act
            clone.Address.City = "Frankfurt";

            // Assert
            Assert.Equal("Frankfurt", orignal.Address.City);
        }
    }
}