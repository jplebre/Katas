using System;
using Katas.VideoRental.Specflow.Models;
using NUnit;
using NUnit.Framework;
using Rhino.Mocks;

namespace Katas.VideoRental.Specflow.UnitTest
{
    public class RentalTests
    {
        private User TestUser;
        private Title TestTitle;
        private RentalEngine _rentalEngine;
        private ILibrary _library;
        private IEmailServices _emailServices;
        private Registry _registry;

        [SetUp]
        public void SetUp()
        {
            TestUser = new User
            {
                Name = "John Doe",
                Email = "john.doe@aol.com",
                Age = 28,
                UserStatus = UserStatus.MEMBER
            };

            TestTitle = new Title
            {
                TitleName = "Pulp Fiction",
                Director = "Quentin Tarantino",
                YearOfRelease = 1995
            };

            _library = new Library();
            _emailServices = new EmailServices();
            _registry = new Registry();

            _rentalEngine = new RentalEngine(_library, _emailServices, _registry, new CMSEntries());
        }

        [Test]
        public void UserRentsTitle()
        {
            _rentalEngine.UserRentsTitle(TestUser,TestTitle);

            Assert.That(_rentalEngine.GetRentals()[0].UserCheckingOut, Is.EqualTo(TestUser) );
            Assert.That(_rentalEngine.GetRentals()[0].CheckedOutTitle, Is.EqualTo(TestTitle));
        }

        [Test]
        public void RentalTimeIncludesCorrectCheckoutDate()
        {
            _rentalEngine.UserRentsTitle(TestUser,TestTitle);
            DateTime now = DateTime.Today;

            Assert.That(_rentalEngine.GetRentals()[0].CheckOutTime, Is.EqualTo(now));
        }

        [Test]
        public void RentalTimeIncludesCorrectDueByDate()
        {
            _rentalEngine.UserRentsTitle(TestUser, TestTitle);
            DateTime now = DateTime.Today.AddDays(15);

            Assert.That(_rentalEngine.GetRentals()[0].DueByDate, Is.EqualTo(now));
        }

        [Test]
        public void UserDonatesTitleAndTitleIsAddedToLibrary()
        {
            _rentalEngine.UserDonatesTitle(TestUser, TestTitle);

            Assert.That(_library.GetLibrary().ContainsKey(TestTitle), Is.True);
        }

        [Test]
        public void UserDonatesTitleAndUserReceivesLoyaltyPoints()
        {
            
        }
    }
}
