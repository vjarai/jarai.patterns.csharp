using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jarai.Patterns.Behavioral.State.Tests
{
    [TestClass]
    public class TelefonTests
    {
        [TestMethod]
        public void Abheben_should_change_State_to_abgehoben()
        {
            // Arrange
            var target = new Telefon();

            // Act
            target.Abheben();

            // Assert
            Assert.IsInstanceOfType(target.AKtuellerZustand, typeof(Abgehoben));
        }
    }
}