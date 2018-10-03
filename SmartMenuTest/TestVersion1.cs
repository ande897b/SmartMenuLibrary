using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;

namespace SmartMenuTest
{
    [TestClass]
    public class TestVersion1
    {
        [TestMethod]
        public void TestInput1()
        {
            SmartMenu smartmenu = new SmartMenu();
            
            Assert.AreEqual("MenuSpecDK.txt", smartmenu.ChooseLanguage(1));
        }
        [TestMethod]
        public void TestInput2()
        {
            SmartMenu smartmenu = new SmartMenu();

            Assert.AreEqual("MenuSpecENG.txt", smartmenu.ChooseLanguage(2));
        }
        [TestMethod]
        public void TestInput3()
        {
            SmartMenu smartmenu = new SmartMenu();

            Assert.AreEqual("Fejl", smartmenu.ChooseLanguage(3));
        }
        [TestMethod]
        public void TestCase1()
        {
            SmartMenu smartmenu = new SmartMenu();

            Assert.AreEqual("Farvel", smartmenu.Activate());
        }
    }
}
