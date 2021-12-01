using System;
using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class PublicationTests
    {
        private MaterialType carton;
        private Material caja;
        private Material placa;

        [SetUp]
        public void Setup()
        {
            carton = new MaterialType("Cartón");
            caja = new Material("Caja de cartón", carton);
            placa = new Material("Placa de cartón", carton);
        }

        [Test]
        public void AddItemTest()
        {
            Publication publication = new Publication(DateTime.Today);
            IPublicationItem item =  publication.AddItem(caja, 1, 1);
            IPublicationItem discount = publication.AddDiscount(-1);

            Assert.That(publication.Items, Has.Member(item));
            Assert.That(publication.Items, Has.Member(discount));
        }

        [Test]
        public void RemoveItemTest()
        {
            Publication publication = new Publication(DateTime.Today);
            IPublicationItem item = publication.AddItem(caja, 1, 1);
            IPublicationItem discount = publication.AddDiscount(-1);
            Assert.That(publication.Items, Has.Member(item));
            Assert.That(publication.Items, Has.Member(discount));

            publication.RemoveItem(item);
            Assert.That(publication.Items, Has.None.EqualTo(item));

            publication.RemoveItem(discount);
            Assert.That(publication.Items, Has.None.EqualTo(discount));
        }

        [Test]
        public void TotalTest()
        {
            Publication publication = new Publication(DateTime.Today);
            PublicationItem item1 = publication.AddItem(caja, 2, 2);
            PublicationItem item2 = publication.AddItem(placa, 3, 4);
            PublicationDiscount discount = publication.AddDiscount(-1);
            int expected = item1.Quantity * item1.Price + item2.Quantity * item2.Price -1;

            Assert.That(publication.Total, Is.EqualTo(expected));
        }

        [Test]
        public void AddInvalidDiscount()
        {
            Publication publication = new Publication(DateTime.Today);
            Assert.That(() => publication.AddDiscount(1), Throws.TypeOf<ArgumentException>());            
        }
    }
}