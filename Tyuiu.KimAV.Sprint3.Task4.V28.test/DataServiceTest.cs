using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task4.V28.Lib;
namespace Tyuiu.KimAV.Sprint3.Task4.V28.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var wait = 1.924;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
