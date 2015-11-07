using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Katas.ClamCard.Specflow.Tests
{
    [Binding]
    public class SimpleJourneysSteps
    {
        private Passenger _michael;

        [Given(@"Michael has an Oyster Card")]
        public void GivenMichaelHasAnOysterCard()
        {
            _michael = new Passenger("Michael");
            _michael.BuyNewOysterCard();
        }
        
        [Given(@"Michael travels from Asterisk to Aldgate")]
        public void GivenMichaelTravelsFromAsteriskToAldgate()
        {
            Station stationA = new Station("Asterisk", Zone.A);
            Station stationB = new Station("Aldgate", Zone.A);
            Journey journey = new Journey(stationA, stationB);

            _michael.PerformJourney(journey);
        }
        
        [Given(@"Michael travels from Asterisk to Barbican")]
        public void GivenMichaelTravelsFromAsteriskToBarbican()
        {
            Station stationA = new Station("Asterisk", Zone.A);
            Station stationB = new Station("Barbican", Zone.B);
            Journey journey = new Journey(stationA, stationB);

            _michael.PerformJourney(journey);
        }
        
        [Given(@"Michael travels from Barbican to Balham")]
        public void GivenMichaelTravelsFromBarbicanToBalham()
        {
            Station stationA = new Station("Barbican", Zone.B);
            Station stationB = new Station("Balham", Zone.B);
            Journey journey = new Journey(stationA, stationB);

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
