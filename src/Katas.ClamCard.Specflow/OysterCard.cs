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
        private Zone _zoneUsed;
        public List<Journey> JourneyList;
        public decimal DailyCostCap { get; private set; }
             
        public OysterCard()
        {
            JourneyList = new List<Journey>();
            _zoneUsed = Zone.A;
            DailyCostCap = Prices.DailyCapZoneA;
        }

        public void AddJourney(Journey journey)
        {
            if (JourneyList.Count >= 1)
                journey.CheckIsReturnJourney(JourneyList.Last());

            JourneyList.Add(journey);
            CheckZoneUsage(journey);

            CalculateDiscount();
        }

        public void DailyReset()
        {
            JourneyList.Clear();
        }

        public decimal CalculateDailyCost()
        {
            return JourneyList.Sum(x => x.Cost);
        }

        private void CheckZoneUsage(Journey journey)
        {
            if (_zoneUsed < journey.Zone)
            {
                DailyCostCap = Prices.DailyCapZoneB;
                _zoneUsed = Zone.B;
            }
        }

        private void CalculateDiscount()
        {
            decimal dailyCost = CalculateDailyCost();
            if (dailyCost >= DailyCostCap)
            {
                Journey lastJourney = JourneyList[JourneyList.Count - 1];
                decimal discount = dailyCost - DailyCostCap;

                lastJourney.SetDiscount(discount);
            }
        }
    }
}
