using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusinND.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MusinND.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Никита";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Никита", res);
        }
    }
}
