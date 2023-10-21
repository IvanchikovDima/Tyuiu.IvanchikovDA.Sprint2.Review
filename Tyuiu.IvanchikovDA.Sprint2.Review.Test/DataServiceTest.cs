using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint2.Review.Lib;

namespace Tyuiu.IvanchikovDA.Sprint2.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}