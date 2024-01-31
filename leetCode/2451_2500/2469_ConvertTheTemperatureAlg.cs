using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2451_2500
{
    public class _2469_ConvertTheTemperatureAlg
    {
        public double[] ConvertTemperature(double celsius)
        {
            double[] result = new double[2];
            result[0] = Math.Round(celsius + 273.15, 5);
            result[1] = Math.Round(celsius * 1.8 + 32.00, 5);
            return result;
        }
    }
}
