using NUnit.Framework;
using Ucu.Poo.Defense;

namespace Ucu.Poo.Defense.Tests
{
    [TestFixture]
    public class MaterialTypeTests
    {

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