using NuGet.Frameworks;
using Tyuiu.DikanovAA.Sprint1.Task7.V15.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 21.484;
            var res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);
        }
    }
}