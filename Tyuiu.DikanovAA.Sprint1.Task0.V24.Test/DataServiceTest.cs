using Tyuiu.DikanovAA.Sprint1.Task0.V24.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}