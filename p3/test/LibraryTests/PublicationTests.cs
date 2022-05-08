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
            PublicationItem item = new PublicationItem(caja, 1, 1);
            publication.AddItem(item);

            Assert.That(publication.Items, Has.Member(item));
        }

        [Test]
        public void RemoveItemTest()
        {
            Publication publication = new Publication(DateTime.Today);
            PublicationItem item = new PublicationItem(caja, 1, 1);
            publication.AddItem(item);
            Assert.That(publication.Items, Has.Member(item));

            publication.RemoveItem(item);
            Assert.That(publication.Items, Has.None.EqualTo(item));
        }

        [Test]
        public void TotalTest()
        {
            Publication publication = new Publication(DateTime.Today);
            PublicationItem item1 = new PublicationItem(caja, 1, 1);
            PublicationItem item2 = new PublicationItem(placa, 2, 2);
            publication.AddItem(item1);
            publication.AddItem(item2);
            int expected = item1.Quantity * item1.Price + item2.Quantity * item2.Price;

            Assert.That(publication.TotalPrice, Is.EqualTo(expected));
        }
    }
}