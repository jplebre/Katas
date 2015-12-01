using System;
using System.ComponentModel;
using NUnit.Framework;

namespace Katas.VideoRental.Specflow.UnitTest
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;
        private Registry _registry;
        
        [SetUp]
        public void TestSetup()
        {
            _library = new Library();
            _registry = new Registry();
        }

        [Test]
        public void LibraryKeepsTrackOfTitles()
        {
            Assert.That(_library.Titles, Is.Not.Null);
        }

        [Test]
        public void LibraryRegistersNewTitles()
        {
            Title title = new Title("PulpFiction", "Quentin Tarantino", 1985, 1);
            _library.AddTitleToLibrary(title);
            Assert.That(_library.Titles[0], Is.EqualTo(title));
        }
    }
}