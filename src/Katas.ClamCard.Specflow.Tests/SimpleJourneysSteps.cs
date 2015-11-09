using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Katas.ClamCard.Specflow.Tests
{
    [Binding]
    public class SimpleJourneysSteps
    {
        private Passenger _michael;
        private List<Station> _stations;

        [BeforeScenario]
        public void SetUp()
        {
            _stations = new List<Station>();
            _stations.Add(new Station("Asterisk", Zone.A));
            _stations.Add(new Station("Aldgate", Zone.A));
            _stations.Add(new Station("Angel", Zone.A));
            _stations.Add(new Station("Antelope", Zone.A));
            _stations.Add(new Station("Balham", Zone.B));
            _stations.Add(new Station("Barbican", Zone.B));
            _stations.Add(new Station("Bison", Zone.B));
        }

        [Given(@"Michael has an Oyster Card")]
        public void GivenMichaelHasAnOysterCard()
        {
            _michael = new Passenger("Michael");
            _michael.BuyNewOysterCard();
        }
        
        [Given(@"Michael travels from (.*) to (.*)")]
        public void GivenMichaelTravelsFromOriginToDestination(string origin, string destination)
        {
            Journey journey = new Journey(
                _stations.Find(x => x.Name == origin),
                _stations.Find(x => x.Name == destination)
                );

            _michael.PerformJourney(journey);
        }
        
        [Then(@"Michael will be charged £(.*) for his first journey")]
        public void ThenMichaelWillBeChargedForHisJourney(Decimal cost)
        {
            Assert.AreEqual(cost, _michael.GetJourneyCost(1));
        }
        
        [Then(@"a further £(.*) for his second journey")]
        public void ThenAFurtherForHisSecondJourney(Decimal cost)
        {
            Assert.AreEqual(cost, _michael.GetJourneyCost(2));
        }

        [Then(@"a further £(.*) for his third journey")]
        public void ThenAFurtherForHisThirdJourney(Decimal cost)
        {
            Assert.AreEqual(cost, _michael.GetJourneyCost(3));
        }

        [Then(@"a further £(.*) for his fourth journey")]
        public void ThenAFurtherForHisFourthJourney(Decimal cost)
        {
            Assert.AreEqual(cost, _michael.GetJourneyCost(4));
        }
    }
}
