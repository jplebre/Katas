﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.ClamCard.Specflow
{
    public class Journey
    {
        public Station Origin { get; private set; }
        public Station Destination { get; private set; }
        public decimal Cost { get; private set; }

        public Journey(Station origin,Station destination)
        {
            Origin = origin;
            Destination = destination;
            Cost = CalculateCost();
        }

        private decimal CalculateCost()
        {
            var fare = Math.Max((int)Origin.Zone, (int)Destination.Zone);
            switch (fare)
            {
                case 0:
                    return 2.5m;
                    break;
                case 1:
                    return 3.0m;
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
