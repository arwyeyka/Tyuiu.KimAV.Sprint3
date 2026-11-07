using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.KimAV.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            var wait = 0.69;

            Assert.AreEqual(wait, res);
        }
    }
}