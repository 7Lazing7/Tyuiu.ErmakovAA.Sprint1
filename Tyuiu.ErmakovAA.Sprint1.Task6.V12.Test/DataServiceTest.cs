using Tyuiu.ErmakovAA.Sprint1.Task6.V12.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLastWordRepetiton()
        {
            string strTest = "Hello World";
            DataService ds = new DataService();
            string res = ds.EndsWith( strTest );
            string wait = "World";
            Assert.AreEqual ( strTest, res );
        }
    }
}