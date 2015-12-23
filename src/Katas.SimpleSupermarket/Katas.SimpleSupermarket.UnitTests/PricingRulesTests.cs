using System;
using NUnit.Framework;

namespace Katas.SimpleSupermarket.UnitTests
{
    [TestFixture]
    public class PricingRulesTests
    {
        [Test]
        public void ScanProductAShouldReturnBillOfFifty()
        {
            Assert.That(new PricingRules().ItemPrice("A"), Is.EqualTo(50));
        }

        [Test]
        public void ScanProductBShouldReturnBillOfThirty()
        {
            Assert.That(new PricingRules().ItemPrice("B"), Is.EqualTo(30));
        }

        [Test]
        public void ScanProductCShouldReturnBillOfThirty()
        {
            Assert.That(new PricingRules().ItemPrice("C"), Is.EqualTo(20));
        }

        [Test]
        public void ScanProductDShouldReturnBillOfThirty()
        {
            Assert.That(new PricingRules().ItemPrice("D"), Is.EqualTo(15));
        }
    }
}