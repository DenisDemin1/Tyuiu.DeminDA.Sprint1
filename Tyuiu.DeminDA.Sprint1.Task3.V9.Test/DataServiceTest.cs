using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.DeminDA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            int wait = 1;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(wait, res);


        }
    }
}
