using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            DailyCostCap = 7.00m;
        }

        public void AddJourney(Journey journey)
        {
            JourneyList.Add(journey);
            decimal dailyCost = CalculateDailyCost();
            if (dailyCost >= DailyCostCap)
            {
                Journey lastJourney = JourneyList[JourneyList.Count - 1];
                decimal discount = dailyCost - DailyCostCap;

                lastJourney.SetDiscount(discount);
            }
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
