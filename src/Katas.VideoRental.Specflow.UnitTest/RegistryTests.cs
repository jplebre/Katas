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
        private User TestUser;
        private User Administrator;
        private Title TestTitle;


        [SetUp]
        public void SetUp()
        {
            TestUser = new User
            {
                Name ="John Doe",
                Email = "john.doe@aol.com",
                Age = 28,
                UserStatus = UserStatus.MEMBER
            };

            Administrator = new User
            {
                Name = "Sarah Jane",
                Email = "sarah.jane@aol.com",
                Age = 24,
                UserStatus = UserStatus.ADMINISTRATOR
            };

            TestTitle = new Title
            {
                TitleName = "Pulp Fiction",
                Director = "Quentin Tarantino",
                YearOfRelease = 1995
            };

            _stubEmailServices = MockRepository.GenerateStub<IEmailServices>();
            _stubEmailServices.Stub(x => x.SendUserWelcomeEmail(TestUser));

            _registry = new Registry(_stubEmailServices);
        }


        [Test]
        public void RegistryKeepsTrackOfUsers()
        {
            Assert.That(_registry.GetListOfUsers(), Is.Not.Null);
        }

        [Test]
        public void RegistryRegistersNewUsers()
        {
            _registry.RegisterUser(TestUser);

            Assert.That(_registry.GetListOfUsers()[0], Is.EqualTo(TestUser));
        }

        [Test]
        public void RegisteredUsersHaveAllFields()
        {
            User UserWithoutFields = new User()
            {
            };
            _registry.RegisterUser(UserWithoutFields);

            Assert.That(_registry.GetListOfUsers().Contains(UserWithoutFields), Is.False);
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

            Assert.That(!_registry.GetListOfUsers().Contains(underagedUser));
        }

        [Test]
        public void RegistrySendsUserWelcomeEmail()
        {
            _registry.RegisterUser(TestUser);

            _stubEmailServices.Expect(x => x.SendUserWelcomeEmail(TestUser));
        }

        [Test]
        public void UserAddsTitleToWishlistInLowerCase()
        {
            string userWishedTitleName = "Pulp Fiction";
            _registry.UserAddsTitleToWishlist(TestUser, userWishedTitleName);

            Assert.That(TestUser.Wishlist.Contains(userWishedTitleName.ToLower()), Is.True);
        }

        [Test]
        public void WishlistTitlesAreInLowerCase()
        {
            string userWishedTitleName = "Pulp Fiction";
            _registry.UserAddsTitleToWishlist(TestUser, userWishedTitleName);

            Assert.That(_registry.CheckUserWishlistForTitle(TestUser, userWishedTitleName), Is.True);
        }
    }
}
