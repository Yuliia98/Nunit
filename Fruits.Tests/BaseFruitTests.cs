using NUnit.Framework;
using Fruit;
using System;

namespace Fruits.Tests
{
    [TestFixture]
    public class BaseFruitTests
    {
        [Test]        
        public void ShouldGetFruitsPriceByWeight() {

            var fruit = new BaseFruit(2.5, 12, "someFruit", "black", 10);

            var actualPriceByWeight = fruit.GetFruitsPriceByWeight();

            Assert.AreEqual(actualPriceByWeight, 25);            
        }

        [Test]
        public void ShouldGetFruitsPriceByWeight_ThrowsWeightException()
        {

            var fruit = new BaseFruit(-2.5, 12, "someFruit", "black", 10);

            Assert.Throws<ArgumentOutOfRangeException>(() => fruit.GetFruitsPriceByWeight());
        }

        [Test]
        public void ShouldGetFruitsPriceByWeight_ThrowsPriceException()
        {

            var fruit = new BaseFruit(2.5, 12, "someFruit", "black", -10);

            Assert.Throws<ArgumentOutOfRangeException>(() => fruit.GetFruitsPriceByWeight());
        }

        [Test]
        public void ShouldGetFruitsPriceByAmount()
        {
            var fruit = new BaseFruit(2.5, 12, "someFruit", "black", 10);

            var actualPriceByWeight = fruit.GetFruitsPriceByAmount();

            Assert.AreEqual(actualPriceByWeight, 120);
        }

        [Test]
        public void ShouldGetTotalWeight() {

            var fruit = new BaseFruit(2.5, 12, "someFruit", "black", 10);

            var actualPriceByWeight = fruit.GetTotalWeight();

            Assert.AreEqual(actualPriceByWeight, 30);
        }       
    }
}
