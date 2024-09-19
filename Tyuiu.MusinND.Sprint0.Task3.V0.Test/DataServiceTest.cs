using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusinND.Sprint0.Task3.V0.Lib;

namespace Tyuiu.MusinND.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedVsalid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
