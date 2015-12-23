using System;
using NUnit.Framework;

namespace Katas.SimpleSupermarket.UnitTests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void EnsureBillIsZeroForANewCostumer()
        {
            Assert.That(new Checkout().GetBill(), Is.EqualTo(0));
        }

        [Test]
        public void ScanOneItem()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("A");
            Assert.That(checkout.GetBill(), Is.EqualTo(50));
        }

        [Test]
        public void ScanSeveralItems()
        {
            Checkout checkout = new Checkout();
            checkout.Scan("ABCD");
            Assert.That(checkout.GetBill(), Is.EqualTo(115));
        }
    }
}