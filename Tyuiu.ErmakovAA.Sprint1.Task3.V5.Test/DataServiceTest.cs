using Tyuiu.ErmakovAA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressione()
        {
            DataService ds = new DataService();
            double mapScale = 2;
            double distanceBetweenPoints = 3;
            double wait = 6;
            var res = ds.DistanceLength(mapScale, distanceBetweenPoints);
            Assert.AreEqual(wait, res);
        }
    }
}
