using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;


namespace DateUnitTestProject
{
    [TestClass]
    public class UnitTestDate
    {
        UclDate aDate;
        [TestInitialize]
        public void Initializer()
        {
            aDate = new UclDate(2019, 6, 2);
        }
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
          
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");
            
        }
        [TestMethod]
        public void TestMethod_GetDay()
        {
            Assert.AreEqual(2, aDate.GetDay());
        }

        [TestMethod]
        public void TestMethod_GetMonth()
        {
            Assert.AreEqual(aDate.GetMonth(), 2);
            //Godtager tal som er > 12. 
        }

        [TestMethod]
        public void TestMethod_GetYear()
        {
            Assert.AreEqual(2019, aDate.GetYear());
        }

        [TestMethod]
        public void TestMethod_SetYear()
        {
            aDate.SetYear(2020);
            Assert.AreEqual(2020, aDate.GetYear());
        }

        [TestMethod]
        public void TestMethod_MoveToPrevDate()
        {
            aDate.MoveToPrevDate();
            Assert.AreEqual("5/2/2019", aDate.GetDatoStringDMY());
        }

        [TestMethod]
        public void TestMethod_MoveToNextDate()
        {
            aDate.MoveToNextDate();
            Assert.AreEqual("2019-02-07", aDate.GetDatoStringYMMDDAlternativ());
        }
    }

    
}
