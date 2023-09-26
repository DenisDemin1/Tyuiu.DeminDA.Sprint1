using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.DeminDA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.797;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait =7;
            Assert.AreEqual(wait, result);

        }
    }
}
