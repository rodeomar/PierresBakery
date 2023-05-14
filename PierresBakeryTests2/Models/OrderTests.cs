using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Models.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void TestOrderConstructor()
        {
            string title = "Test Order";
            string description = "Test description";
            decimal price = 10.50m;
            DateTime date = DateTime.Now;

            Order order = new Order(title, description, price, date);

            Assert.AreEqual(order.Title, title);
            Assert.AreEqual(order.Description, description);
            Assert.AreEqual(order.Price, price);
            Assert.AreEqual(order.Date, date);
        }

        [TestMethod()]
        public void TestOrderTitleProperty()
        {
            string title = "Test Order";
            string description = "Test description";
            decimal price = 10.50m;
            DateTime date = DateTime.Now;

            Order order = new Order(title, description, price, date);

            string newTitle = "New Title";
            order.Title = newTitle;

            Assert.AreEqual(order.Title, newTitle);
        }

        [TestMethod()]
        public void TestOrderPriceProperty()
        {
            string title = "Test Order";
            string description = "Test description";
            decimal price = 10.50m;
            DateTime date = DateTime.Now;

            Order order = new Order(title, description, price, date);

            decimal newPrice = 15.00m;
            order.Price = newPrice;

            Assert.AreEqual(order.Price, newPrice);
        }
    }
}
