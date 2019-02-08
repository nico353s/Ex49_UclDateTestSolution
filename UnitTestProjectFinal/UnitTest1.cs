using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;


namespace UnitTestProjectFinal
{
    [TestClass]
    public class UnitTestDate

    {
        UclDate aDate;
        [TestInitialize]
        public void Initializer()
        {
            aDate = new UclDate(2019, 2, 6);
        }
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");

        }
        [TestMethod]
        public void TestMethod_GetDay()
        {
            
            Assert.AreEqual(aDate.GetDay(), 6);
        }

        [TestMethod]
        public void TestMethod_GetMonth()
        {
            
            Assert.AreEqual(aDate.GetMonth(), 2);
        }
    }

}
