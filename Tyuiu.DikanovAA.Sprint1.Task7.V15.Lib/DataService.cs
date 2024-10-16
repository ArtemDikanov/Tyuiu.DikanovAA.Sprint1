﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DikanovAA.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double res = (Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3))) - ((Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x));
            return res;
        }
    }
}