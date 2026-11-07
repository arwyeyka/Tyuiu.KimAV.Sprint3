using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task6.V22.Lib;
namespace Tyuiu.KimAV.Sprint3.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 19;
            int stopValue = 31;
            var res = ds.GetSumTheDivisors(startValue, stopValue);
            var wait = 55;
            Assert.AreEqual(wait, res);
        }
    }
}
