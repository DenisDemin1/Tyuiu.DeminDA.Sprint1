﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint1.Task4.V9.Lib;

namespace Tyuiu.DeminDA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y =4;
            double wait = -2.213 ;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
