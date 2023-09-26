using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DeminDA.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9

    {
        public double Calculate(double x, double y)
        {
            var res = Math.Log(x * y) / ( x - Math.Sqrt(1 + Math.Pow(y,2)));
            var round = Math.Round(res, digits:3);
            return round;
        }
    }
}
