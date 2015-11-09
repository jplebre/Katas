using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Katas.ClamCard.Specflow
{
    public class Passenger
    {
        public string Name { get; private set; }
        public OysterCard OysterCard { get; private set; }

        public Passenger(string name)
        {
            Name = name;
        }

        public void BuyNewOysterCard()
        {
            OysterCard = new OysterCard();
        }

        public void PerformJourney(Journey journey)
        {
            OysterCard.AddJourney(journey);
        }

        public decimal GetJourneyCost(int journeyIndex)
        {
            return OysterCard.JourneyList[journeyIndex-1].Cost;
        }

        public decimal GetTotalDailyCost()
        {
            return OysterCard.CalculateDailyCost();
        }

        public Journey GetJourney(int journeyIndex)
        {
            return OysterCard.JourneyList[journeyIndex - 1];
        }
    }
}
