using Tyuiu.ErmakovAA.Sprint1.Task0.V15.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressione()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
