using System.Globalization;
using Tyuiu.DikanovAA.Sprint1.Task6.V1.Lib;
namespace Tyuiu.DikanovAA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string str = "1";
            DataService ds = new DataService();
            string res = ds.SymbolCode(str);
            string wait = "49";
            Assert.AreEqual(wait, res);


        }
    }
}