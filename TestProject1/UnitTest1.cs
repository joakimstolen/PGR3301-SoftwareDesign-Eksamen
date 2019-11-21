using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SoftDesEksamen;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void CheckThatCustomerExists()
        {
            CarShop shop = new CarShop();
            Customer test = new Customer("Ola", shop);
            Assert.AreEqual(test._name, "Ola");
        }

        [Test]
        public void CheckThatCarExists()
        {
            CarShop shop = new CarShop();
            shop.BuyCar();
            Assert.AreEqual(shop.hasCar, shop.hasCar);
        }

        [Test]
        public void CheckThatTwoCustomersAreNotTheSameAsTheOtherOneSinceTheyAreTwoDifferentPeople()
        {
            CarShop shop = new CarShop();
            Customer test1 = new Customer("Ola", shop);
            Customer test2 = new Customer("NotOla", shop);
            
            Assert.AreNotEqual(test1._name, test2._name);
        }
    }
}