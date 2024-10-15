using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DikanovAA.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            var res = "";
            foreach (char c in value)
            {
                res = Convert.ToString((int)c);
            }
            return res;


















        }
    }
}
