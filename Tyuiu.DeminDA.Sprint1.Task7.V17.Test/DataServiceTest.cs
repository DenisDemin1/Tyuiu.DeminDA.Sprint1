using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint1.Task7.V17.Lib;
namespace Tyuiu.DeminDA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double wait = -2.046;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
