using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.KimAV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestReplaceCharInString()
        {
            DataService ds = new DataService();

            string temp = "gft hggt ntg";
            char one = 'g';
            char two = '*';

            var result = ds.ReplaceCharInString(temp, one, two);
            var wait = "*ft h**t nt*";

            Assert.AreEqual(wait, result);
        }
    }
}