using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ErmakovAA.Sprint1.Task2.V10.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DatsServiceTest
    {
        [TestMethod]
        public void ValidExpressione()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(1, res);
        }
    }
}