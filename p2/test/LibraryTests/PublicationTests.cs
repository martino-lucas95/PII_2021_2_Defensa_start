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
        public void AsTextTest()
        {
            Publication publication = new Publication(DateTime.Today);
            PublicationItem item1 = new PublicationItem(caja, 1, 1);
            PublicationItem item2 = new PublicationItem(placa, 2, 2);
            publication.AddItem(item1);
            publication.AddItem(item2);
            string text = publication.AsText();            

            Assert.That(text, Contains.Substring(item1.Material.Name).IgnoreCase);
            Assert.That(text, Contains.Substring(item1.Quantity.ToString()));
            Assert.That(text, Contains.Substring(item1.Price.ToString()));
            Assert.That(text, Contains.Substring(item2.Material.Name).IgnoreCase);
            Assert.That(text, Contains.Substring(item2.Quantity.ToString()));
            Assert.That(text, Contains.Substring(item2.Price.ToString()));
        }
    }
}