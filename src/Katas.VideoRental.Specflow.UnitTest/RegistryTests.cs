using System;
using System.ComponentModel;
using NUnit.Framework;

namespace Katas.VideoRental.Specflow.UnitTest
{
    [TestFixture]
    public class RegistryTests
    {
        private Registry _registry;

        [SetUp]
        public void SetUp()
        {
            _registry = new Registry();
        }

        [Test]
        public void RegistryKeepsTrackOfUsers()
        {
            Assert.That(_registry.Users, Is.Not.Null);
        }

        [Test]
        public void RegistryRegistersNewUsers()
        {
            User user = new User("John Doe", "john.doe@aol.com", 28);
            _registry.RegisterUser(user);

            Assert.That(_registry.Users[0], Is.EqualTo(user));
        }
    }
}
