using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.ClamCard.Specflow
{
    public class OysterCard
    {
        public List<Journey> JourneyList;
        public decimal DailyCostCap { get; private set; }
             
        public OysterCard()
        {
            JourneyList = new List<Journey>();
        }

        public void AddJourney(Journey journey)
        {
            JourneyList.Add(journey);
        }

        public void DailyReset()
        {
            JourneyList.Clear();
        }

        public decimal CalculateDailyCost()
        {
            return JourneyList.Sum(x => x.Cost);
        }
    }
}
