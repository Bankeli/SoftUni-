using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace AutoTrade.Tests
{
    [TestFixture]
    public class DealerShopTests
    {
        private DealerShop dealerShop;
        private Vehicle testCar;

        [SetUp]
        public void Setup()
        {
            dealerShop = new DealerShop(5);
            testCar = new Vehicle("Audi", "A3", 2005);
        }

        [Test]
        public void ConstructorWithPositiveCapacitySetsCapacityAndInitializesEmptyList()
        {
            var shop = new DealerShop(5);

            // Assert
            Assert.AreEqual(5, shop.Capacity);
            Assert.AreEqual(0, shop.Vehicles.Count);
            Assert.IsInstanceOf<IReadOnlyCollection<Vehicle>>(shop.Vehicles);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void ConstructorShouldThrowArgumentExceptionIfCapacityIsNegative(int capacity)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new DealerShop(capacity));
            Assert.AreEqual("Capacity must be a positive value.", ex.Message);
        }

        [Test]
        public void AddVehicleWhenSpaceAvailable()
        {
            var shop = new DealerShop(2);
            var car = new Vehicle("Audi", "A3", 2000);

            var result = shop.AddVehicle(car);

            Assert.AreEqual(1, shop.Vehicles.Count);
            Assert.AreEqual("Added 2000 Audi A3", result);
        }

        [Test]
        public void AddVehicleWhenInventoryFullThrowsInvalidOperationException()
        {
            var shop = new DealerShop(1);
            var car = new Vehicle("Audi", "A3", 2000);
            shop.AddVehicle(car);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => shop.AddVehicle(new Vehicle("VW", "Golf", 1995)));
            Assert.AreEqual("Inventory is full", ex.Message);
        }

        [Test]
        public void SellVehicle_WhenVehicleExists()
        {
            dealerShop.AddVehicle(testCar);

            var sold = dealerShop.SellVehicle(testCar);

            Assert.IsTrue(sold);
            Assert.AreEqual(0, dealerShop.Vehicles.Count);
        }


        [Test]
        public void SellVehicleWhenVehicleDoesNotExistReturnsFalseAndDoesNotModifyInventory()
        {
            var notInShop = new Vehicle("BMW", "M3", 2022);
            dealerShop.AddVehicle(testCar);

            bool sold = dealerShop.SellVehicle(notInShop);

            Assert.IsFalse(sold);
            Assert.AreEqual(1, dealerShop.Vehicles.Count);
            Assert.Contains(testCar, dealerShop.Vehicles.ToList());
        }

        [Test]
        public void InventoryReportWhenEmptyReturnsCorrectHeaderAndCounts()
        {
            string report = dealerShop.InventoryReport();

            string expected =
             $"Inventory Report{ Environment.NewLine}" +
             $"Capacity: 5{Environment.NewLine}" +
             $"Vehicles: 0";

            Assert.AreEqual(expected, report);
        }
    }
}
