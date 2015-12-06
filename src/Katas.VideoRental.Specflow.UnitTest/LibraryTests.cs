using System;
using System.ComponentModel;
using NUnit.Framework;

namespace Katas.VideoRental.Specflow.UnitTest
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;
        private Title _testTitle;
        
        [SetUp]
        public void TestSetup()
        {
            _library = new Library();
            _testTitle = new Title
            {
                TitleName = "Test Name",
                Director = "John Doe",
                YearOfRelease = 1900
            };
        }

        [Test]
        public void LibraryKeepsTrackOfTitles()
        {
            Assert.That(_library.Titles, Is.Not.Null);
        }

        [Test]
        public void WhenRegistringANewTitleANewKeyPairIsCreated()
        {
            Title title = new Title
            {
                TitleName = "PulpFiction",
                Director = "Quentin Tarantino",
                YearOfRelease = 1985
            };
            _library.AddTitleToLibrary(title);

            Assert.That(_library.Titles, Contains.Key(title));
            Assert.That(_library.Titles[title], Is.EqualTo(1));
        }

        [Test]
        public void WhenRegistringExistingTitleKeyPairValueIsIncremented()
        {
            Title title = new Title
            {
                TitleName = "PulpFiction",
                Director = "Quentin Tarantino",
                YearOfRelease = 1985
            };
            _library.AddTitleToLibrary(title);
            _library.AddTitleToLibrary(title);

            Assert.That(_library.Titles, Contains.Key(title));
            Assert.That(_library.Titles[title], Is.EqualTo(2));
        }

    }
}