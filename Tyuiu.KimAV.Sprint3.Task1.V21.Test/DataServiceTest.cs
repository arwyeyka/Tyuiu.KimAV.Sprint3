using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task1.V21.Lib;
namespace Tyuiu.KimAV.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 12;
            double wait = 16947810.88;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}