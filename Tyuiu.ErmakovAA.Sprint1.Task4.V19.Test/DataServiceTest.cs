using Tyuiu.ErmakovAA.Sprint1.Task4.V19.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressione()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
