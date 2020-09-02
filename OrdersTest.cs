using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using CanteenManagementSystem;

namespace CanteenManagementSystem.Test
{
    /// <summary>
    /// Summary description for CustomerTest
    /// </summary>
    [TestFixture]
    public class OrdersTest
    {
        [Test]
        public void TestToString()
        {
            Orders o = new Orders(1, 2, 50.00, 5, 250.00);
            string s = "OrderId : 1 FoodId : 2 FoodPrice : 50 Quantity : 5 TotalAmount : 250";
            Assert.AreEqual(o.ToString(), s);
            //Assert.That(s == c.ToString());
        }

        [Test]
        public void TestConstructor()
        {
            Orders o = new Orders(1, 2, 50.00, 5, 250.00);

            Assert.AreEqual(o.Oid, 1);
            Assert.AreEqual(o.FoodId, 2);
            Assert.AreEqual(o.FoodPrice, 50.00);
            Assert.AreEqual(o.Quantity, 5);
            Assert.AreEqual(o.TotalAmount, 250.00);
        }

        public void PlaceOrderTest()
        {

        }

        [Test]
        public void TestProperty()
        {
            Orders o = new Orders();

            o.Oid = 1;
            o.FoodId = 2;
            o.FoodPrice = 50.00;
            o.Quantity = 5;
            o.TotalAmount = 250.00;

            Assert.AreEqual(o.Oid, 1);
            Assert.AreEqual(o.FoodId, 2);
            Assert.AreEqual(o.FoodPrice, 50.00);
            Assert.AreEqual(o.Quantity, 5);
            Assert.AreEqual(o.TotalAmount, 250.00);
        }
    }
}
