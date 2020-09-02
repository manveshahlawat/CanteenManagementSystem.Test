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
    public class VendorTest
    {
        [Test]
        public void TestToString()
        {
            Vendor v = new Vendor(1, "Manvesh", "9456987123");
            string s = "Vendor Id 1 Vendor Name Manvesh Vendor Phone 9456987123";
            Assert.AreEqual(v.ToString(), s);
            //Assert.That(s == c.ToString());
        }

        [Test]
        public void TestConstructor()
        {
            Vendor v = new Vendor(1, "Manvesh", "9456987123");

            Assert.AreEqual(v.VID, 1);
            Assert.AreEqual(v.VName, "Manvesh");
            Assert.AreEqual(v.VNO, "9456987123");
        }

        [Test]
        public void TestProperty()
        {
            Vendor v = new Vendor();

            v.VID = 1;
            v.VName = "Manvesh";
            v.VNO = "7896541230";

            Assert.AreEqual(v.VID, 1);
            Assert.AreEqual(v.VName, "Manvesh");
            Assert.AreEqual(v.VNO, "7896541230");

        }
    }
}
