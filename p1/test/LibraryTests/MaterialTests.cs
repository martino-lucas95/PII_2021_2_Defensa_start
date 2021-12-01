using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class MaterialTests
    {
        MaterialType dangerousType;
        MaterialType nonDangerousType;

        [SetUp]
        public void Setup()
        {
            this.nonDangerousType = new MaterialType("Non dangerous type", false);
            this.dangerousType = new MaterialType("Dangerous type", true);
        }

        [Test]
        public void TestCreateNonDangerousMaterial()
        {
            Material material = new Material("Non dangerous material", nonDangerousType);
            Assert.That(material.IsDangerous, Is.False);
        }

        [Test]
        public void TestCreateDangerousMaterial()
        {
            Material material = new Material("Dangerous material", dangerousType);

            Assert.That(material.IsDangerous, Is.True);

        }
    }
}