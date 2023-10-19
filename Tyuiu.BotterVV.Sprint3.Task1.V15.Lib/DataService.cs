using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BotterVV.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            value = 2;
            while (startValue <= stopValue)
            {
                multiplySeries = multiplySeries * ((Math.Pow(value, 2)) + 1);
                startValue++;
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
