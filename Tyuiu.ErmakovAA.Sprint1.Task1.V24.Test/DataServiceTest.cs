using Tyuiu.ErmakovAA.Sprint1.Task1.V24.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressione()
        {
            double x = 1; double y = 1;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
