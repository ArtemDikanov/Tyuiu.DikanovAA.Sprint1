using Tyuiu.DikanovAA.Sprint1.Task2.V1.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(3.218, res);

        }
    }
}