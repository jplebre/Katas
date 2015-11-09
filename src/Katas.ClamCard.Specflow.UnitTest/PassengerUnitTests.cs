using System;
using System.Net.NetworkInformation;
using NUnit.Framework;

namespace Katas.ClamCard.Specflow.Tests
{
    [TestFixture]
    public class PassengerUnitTests
    {
        private Passenger passenger;
        private Station zoneAStation1;
        private Station zoneAStation2;
        private Station zoneBStation1;

        [SetUp]
        public void SetUp()
        {
            zoneAStation1 = new Station("Asterisk", Zone.A);
            zoneAStation2 = new Station("Aldgate", Zone.A);
            zoneBStation1 = new Station("Barbican", Zone.B);

            passenger = new Passenger("PassengerName");
            passenger.BuyNewOysterCard();
        }

        [Test]
        public void CreatePassengerWithName()
        {
            Passenger michael = new Passenger("Michael");
            Assert.AreEqual(michael.Name, "Michael");
        }

        [Test]
        public void PassengerBuysAnOysterCard()
        {
            passenger.BuyNewOysterCard();
            Assert.IsNotNull(passenger.OysterCard); 
        }

        [Test]
        public void PassengerPerformsTravel()
        {
            Journey journey = new Journey(zoneAStation1,zoneAStation2);

            passenger.PerformJourney(journey);
            Assert.AreSame(journey, passenger.GetJourney(1));
        }

        [Test]
        public void PassengerChargedForZoneOneTravel()
        {
            decimal zoneOneFare = 2.5m;
            Journey journey = new Journey(zoneAStation1, zoneAStation2);

            passenger.PerformJourney(journey);

            Assert.AreEqual(zoneOneFare, passenger.GetJourneyCost(1));
        }

        [Test]
        public void PassengerChargedForZoneTwoTravel()
        {
            decimal zoneTwoFare = 3.0m;
            Journey journey = new Journey(zoneAStation1, zoneBStation1);

            passenger.PerformJourney(journey);

            Assert.AreEqual(zoneTwoFare, passenger.GetJourneyCost(1));
        }

        [Test]
        public void PassengerChargedForTwoZoneATravels()
        {
            decimal dailyTotal = 5m;
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.AreEqual(dailyTotal, passenger.GetTotalDailyCost());
        }
    }
}
