using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using Katas.VideoRental.Specflow.Models;
using NUnit.Framework;
using Rhino.Mocks;

namespace Katas.VideoRental.Specflow.UnitTest
{
    [TestFixture]
    public class RegistryTests
    {
        private Registry _registry;
        private IEmailServices _stubEmailServices;
        private User User;
        private MailMessage MailMessage;

        [SetUp]
        public void SetUp()
        {
            User = new User
            {
                Name ="John Doe",
                Email = "john.doe@aol.com",
                Age = 28
            };
            MailMessage = new MailMessage();

            _stubEmailServices = MockRepository.GenerateStub<IEmailServices>();
            _stubEmailServices.Stub(x => x.SendUserWelcomeEmail(User));

            _registry = new Registry(_stubEmailServices);
        }

        [Test]
        public void RegistryKeepsTrackOfUsers()
        {
            Assert.That(_registry.Users, Is.Not.Null);
        }

        [Test]
        public void RegistryRegistersNewUsers()
        {
            _registry.RegisterUser(User);

            Assert.That(_registry.Users[0], Is.EqualTo(User));
        }

        [Test]
        public void RegisteredUsersHaveAllFields()
        {
            //Not sure if this is a really meaningfull test
            _registry.RegisterUser(User);
            Assert.That(_registry.Users[0], Is.Not.Null);
        }

        [Test]
        public void RegistryDoesNotRegisterUnderage()
        {
            User underagedUser = new User
            {
                Name = "John Doe",
                Email = "john.doe@aol.com",
                Age = 17
            };
            _registry.RegisterUser(underagedUser);

            Assert.That(!_registry.Users.Contains(underagedUser));
        }

        [Test]
        public void RegistrySendsUserWelcomeEmail()
        {
            _registry.RegisterUser(User);

            _stubEmailServices.Expect(x => x.SendUserWelcomeEmail(User));
        }
    }
}
