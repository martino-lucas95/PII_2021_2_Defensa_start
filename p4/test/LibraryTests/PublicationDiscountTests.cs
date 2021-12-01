using System;
using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class PublicationDiscountTests
    {
        [Test]
        public void CreateValidDiscount()
        {
            Assert.That(() => new PublicationDiscount(-1), Throws.Nothing);
        }

        [Test]
        public void AssignValidDiscount()
        {
            PublicationDiscount discount = new PublicationDiscount(-1);
            Assert.That(() => discount.SubTotal = -2, Throws.Nothing);
        }

        [Test]
        public void CreateInvalidDiscount()
        {
            Assert.That(() => new PublicationDiscount(1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AssignInvalidDiscount()
        {
            PublicationDiscount discount = new PublicationDiscount(-1);
            Assert.That(() => discount.SubTotal = 2, Throws.TypeOf<ArgumentException>());
        }

    }
}