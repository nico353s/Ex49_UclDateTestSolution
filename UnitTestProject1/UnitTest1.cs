using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestDate
    {
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");

        }


        [TestMethod]
        public void TestMethod_GetDay()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(aDate.GetDay(), 6);
        }

        [TestMethod]
        public void TestMethod_GetMonth()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(aDate.GetMonth(), 2);
        }
    }

}
