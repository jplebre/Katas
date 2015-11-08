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
        public void GivenMichaelTravelsFromAsteriskToAldgate(string origin, string destination)
        {
            Journey journey = new Journey(
                _stations.Find(x => x.Name == origin),
                _stations.Find(x => x.Name == destination)
                );

            _michael.PerformJourney(journey);
        }
        
        [Then(@"Michael will be charged £(.*) for his journey")]
        public void ThenMichaelWillBeChargedForHisJourney(Decimal cost)
        {
            Assert.AreEqual(_michael.GetLastJourney().Cost, cost);
        }
        
        [Then(@"a further £(.*) for his second journey")]
        public void ThenAFurtherForHisSecondJourney(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
