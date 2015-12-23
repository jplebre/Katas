using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Katas.SimpleSupermarket
{
    public class Checkout
    {
        private int TotalBill;
        private readonly PricingRules _pricingRules;

        public Checkout():this(new PricingRules())
        {
            TotalBill = 0;
        }

        public Checkout(PricingRules pricingRules)
        {
            TotalBill = 0;
            _pricingRules = pricingRules;
        }

        public int GetBill()
        {
            return TotalBill;
        }

        public void Scan(string itemList)
        {
            foreach (char c in itemList)
            {
                TotalBill += _pricingRules.ItemPrice(c.ToString());
            }
        }
    }
}
