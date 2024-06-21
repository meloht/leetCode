using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.LCP
{
    public class LCP_61
    {
        public int TemperatureTrend(int[] temperatureA, int[] temperatureB)
        {
            int len = temperatureA.Length - 1;
            int n = 0;
            int ans = 0;
            for (int i = 0; i < len; i++)
            {
                int n1 = temperatureA[i] - temperatureA[i + 1];
                int n2 = temperatureB[i] - temperatureB[i + 1];
                if ((n1 == 0 && n2 == 0) || (n1 > 0 && n2 > 0) || (n1 < 0 && n2 < 0))
                {
                    n++;
                }
                else
                {
                    ans = Math.Max(n, ans);
                    n = 0;
                }
            }
            ans = Math.Max(n, ans);
            return ans;
        }
    }
}
