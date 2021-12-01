using NUnit.Framework;
using Ucu.Poo.Defense;

namespace Ucu.Poo.Defense.Tests
{
    public class MaterialTests
    {
        MaterialType type1;
        MaterialType type2;

        [SetUp]
        public void Setup()
        {
            this.type2 = new MaterialType("Type 1");
            this.type1 = new MaterialType("Type 2");
        }

        [Test]
        public void TestSameMaterialsAreEqual()
        {
            Material material1 = new Material("Material 1", type1);
            Material material2 = material1;
            object object1 = material1;

            Assert.True(material1.Equals(material2));
            Assert.True(material1.Equals(object1));
        }

        [Test]
        public void TestMaterialsWithSameValuesAreEqual()
        {
            Material material1 = new Material("Material 1", type1);
            Material material2 = new Material("Material 1", type1);
            object material3 = new Material("Material 1", type1);

            Assert.True(material1.Equals(material2));
            Assert.True(material1.Equals(material3));
            Assert.True(material3.Equals(material1));
        }

        [Test]
        public void TestMaterialsWithDifferentValuesAreNotEqual()
        {
            Material material1 = new Material("Material 1", type1);
            Material material2 = new Material("Material 1", type2);
            Material material3 = new Material("Material 2", type1);

            Assert.False(material1.Equals(null));
            Assert.False(material1.Equals(type1));
            Assert.False(material1.Equals(material2));
            Assert.False(material1.Equals(material3));
        }        
    }
}