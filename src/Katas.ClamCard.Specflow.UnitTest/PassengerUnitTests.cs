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
        private Station zoneAStation3;
        private Station zoneBStation1;
        private Station zoneBStation2;

        [SetUp]
        public void SetUp()
        {
            zoneAStation1 = new Station("Asterisk", Zone.A);
            zoneAStation2 = new Station("Aldgate", Zone.A);
            zoneAStation3 = new Station("Angel", Zone.A);
            zoneBStation1 = new Station("Barbican", Zone.B);
            zoneBStation2 = new Station("Balham", Zone.B);

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
        public void PassengerChargedForZoneATravel()
        {
            decimal zoneOneFare = Prices.SingleZoneA;
            Journey journey = new Journey(zoneAStation1, zoneAStation2);

            passenger.PerformJourney(journey);

            Assert.AreEqual(zoneOneFare, passenger.GetJourneyCost(1));
        }

        [Test]
        public void PassengerChargedForZoneBTravel()
        {
            decimal zoneTwoFare = Prices.SingleZoneB;
            Journey journey = new Journey(zoneAStation1, zoneBStation1);

            passenger.PerformJourney(journey);

            Assert.AreEqual(zoneTwoFare, passenger.GetJourneyCost(1));
        }

        [Test]
        public void PassengerChargedForTwoZoneATravels()
        {
            decimal dailyTotal = Prices.SingleZoneA * 2;
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation3);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.AreEqual(dailyTotal, passenger.GetTotalDailyCost());
        }

        [Test]
        public void PassengerChargedForTwoZoneBTravels()
        {
            decimal dailyTotal = Prices.SingleZoneB * 2;
            Journey journey1 = new Journey(zoneAStation1, zoneBStation1);
            Journey journey2 = new Journey(zoneBStation1, zoneBStation2);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.AreEqual(dailyTotal, passenger.GetTotalDailyCost());
        }

        [Test]
        public void PassengerJourneyIsReturnJourney()
        {
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.IsTrue(journey2.IsReturnJourney);
        }

        [Test]
        public void PassengerJourneyIsNotReturnJourney()
        {
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation3);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.IsFalse(journey2.IsReturnJourney);
        }

        [Test]
        public void PassengerChargedForReturnJourneyZoneA()
        {
            decimal zoneAReturnJourneyFare = Prices.ReturnZoneA;
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.AreEqual(zoneAReturnJourneyFare, passenger.GetJourney(2).Cost);
        }

        [Test]
        public void PassengerChargedForReturnJourneyZoneB()
        {
            decimal zoneBReturnJourneyFare = Prices.ReturnZoneB;
            Journey journey1 = new Journey(zoneAStation1, zoneBStation2);
            Journey journey2 = new Journey(zoneBStation2, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);

            Assert.AreEqual(zoneBReturnJourneyFare, passenger.GetJourney(2).Cost);
        }

        [Test]
        public void DailyCapZoneA()
        {
            decimal dailyCapZoneA = Prices.DailyCapZoneA;
            Journey journey1 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey2 = new Journey(zoneAStation2, zoneAStation1);
            Journey journey3 = new Journey(zoneAStation1, zoneAStation2);
            Journey journey4 = new Journey(zoneAStation2, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);
            passenger.PerformJourney(journey3);
            passenger.PerformJourney(journey4);

            Assert.AreEqual(2.5m, passenger.GetJourney(3).Cost);
            Assert.AreEqual(0.0m, passenger.GetJourney(4).Cost);
        }

        [Test]
        public void DailyCapZoneB()
        {
            decimal dailyCapZoneB = Prices.DailyCapZoneB;
            Journey journey1 = new Journey(zoneAStation1, zoneBStation1);
            Journey journey2 = new Journey(zoneBStation1, zoneAStation1);
            Journey journey3 = new Journey(zoneAStation1, zoneBStation1);
            Journey journey4 = new Journey(zoneBStation1, zoneAStation1);

            passenger.PerformJourney(journey1);
            passenger.PerformJourney(journey2);
            passenger.PerformJourney(journey3);
            passenger.PerformJourney(journey4);

            Assert.AreEqual(2.5m, passenger.GetJourney(3).Cost);
            Assert.AreEqual(0.0m, passenger.GetJourney(4).Cost);
        }
    }
}
