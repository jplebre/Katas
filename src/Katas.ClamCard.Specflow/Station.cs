using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.ClamCard.Specflow
{
    public class Station
    {
        public string Name { get; private set; }
        public Zone Zone { get; private set; }

        public Station(string name, Zone zone)
        {
            Name = name;
            Zone = zone;
        }
    }

    public enum Zone
    {
        A,
        B
    };
}
