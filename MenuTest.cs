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
    public class MenuTest
    {
        [Test]
        public void TestToString()
        {
            Menu m = new Menu(1, "Samosa", 50.00);
            string s = "FoodId : 1 FoodName : Samosa Price : 50";
            Assert.AreEqual(m.ToString(), s);
            //Assert.That(s == c.ToString());
        }

        //public void TestPrintMenu()
        //{
        //    Menu m = new Menu(1, "Samosa", 50.00);
        //    string s = "FoodId : 1 FoodName : Samosa Price : 50";
        //    string a = Convert.ToString( Menu.PrintMenu(m));
        //    Assert.AreEqual(Menu.PrintMenu(m), s);


        //}
        [Test]
        public void TestConstructor()
        {
            Menu m = new Menu(1, "Samosa", 50.00);
            Assert.AreEqual(m.Id, 1);
            Assert.AreEqual(m.Name, "Samosa");
            Assert.AreEqual(m.Price, 50);
        }

        [Test]
        public void TestProperty()
        {
            Menu m = new Menu();

            m.Id = 1;
            m.Name = "Samosa";
            m.Price = 10.00;

            Assert.AreEqual(m.Id, 1);
            Assert.AreEqual(m.Name, "Samosa");
            Assert.AreEqual(m.Price, 10.00);
        }
    }
}
