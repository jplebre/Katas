using System;
using NUnit;
using NUnit.Framework;

namespace Katas.VideoRental.Specflow.UnitTest
{
    public class RentalTests
    {
        private User TestUser;
        private Title TestTitle;
        private RentalEngine _rentalEngine;

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

            _rentalEngine = new RentalEngine();
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
    }
}
