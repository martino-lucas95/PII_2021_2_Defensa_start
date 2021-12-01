using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class MaterialTypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateNonDangerousMaterialType()
        {
            MaterialType materialType = new MaterialType("test", false);

            Assert.That(materialType.IsDangerous, Is.False);
        }

        [Test]
        public void TestCreateDangerousMaterialType()
        {
            MaterialType materialType = new MaterialType("test", true);

            Assert.That(materialType.IsDangerous, Is.True);
        }
    }
}