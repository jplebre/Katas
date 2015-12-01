using System;
using System.ComponentModel;
using NUnit.Framework;

namespace Katas.VideoRental.Specflow.UnitTest
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;
        
        [SetUp]
        public void TestSetup()
        {
            _library = new Library();
        }

        [Test]
        public void LibraryKeepsTrackOfTitles()
        {
            Assert.That(_library.Titles, Is.Not.Null);
        }

        [Test]
        public void LibraryKeepsTrackOfUsers()
        {
            Assert.That(_library.Users, Is.Not.Null);
        }

        [Test]
        public void LibraryRegistersNewUsers()
        {
            _library.RegisterUser("John Doe", "john.doe@aol.com", 28);
            User user = new User("John Doe", "john.doe@aol.com", 28);

            Assert.AreEqual(_library.Users[0],user);
        }
    }
}