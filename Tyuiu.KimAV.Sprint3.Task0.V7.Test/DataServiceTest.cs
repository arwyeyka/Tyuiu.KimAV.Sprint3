using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task0.V7.Lib;
namespace Tyuiu.KimAV.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            var wait = 0.333;

            Assert.AreEqual(wait, res);
        }
    }
}