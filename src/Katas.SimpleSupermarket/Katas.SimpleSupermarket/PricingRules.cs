namespace Katas.SimpleSupermarket
{
    public class PricingRules
    {
        public int ItemPrice(string itemSKU)
        {
            switch (itemSKU)
            {
                case "A":
                    return 50;
                case "B":
                    return 30;
                case "C":
                    return 20;
                case "D":
                    return 15;
                default:
                    return 0;
            }
        }
    }
}