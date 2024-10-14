using Tyuiu.DikanovAA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.083;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}