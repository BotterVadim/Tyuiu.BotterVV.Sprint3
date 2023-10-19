using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BotterVV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multiplySeries = multiplySeries * (Math.Pow((1 / i), (-3)));
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
