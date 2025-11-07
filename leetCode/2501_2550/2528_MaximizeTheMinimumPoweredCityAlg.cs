using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2501_2550
{
    public class _2528_MaximizeTheMinimumPoweredCityAlg
    {
        public long MaxPower(int[] stations, int r, int k)
        {
            int n = stations.Length;
            // 前缀和
            long[] sum = new long[n + 1];
            for (int i = 0; i < n; i++)
            {
                sum[i + 1] = sum[i] + stations[i];
            }

            // 初始电量
            long[] power = new long[n];
            long mn = long.MaxValue;
            for (int i = 0; i < n; i++)
            {
                power[i] = sum[Math.Min(i + r + 1, n)] - sum[Math.Max(i - r, 0)];
                mn = Math.Min(mn, power[i]);
            }

            // 开区间二分
            long left = mn + k / n;
            long right = mn + k + 1;
            while (left + 1 < right)
            {
                long mid = left + (right - left) / 2;
                if (check(mid, power, r, k))
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return left;

        }

        private bool check(long low, long[] power, int r, int k)
        {
            int n = power.Length;
            long[] diff = new long[n + 1];
            long sumD = 0;
            long built = 0;
            for (int i = 0; i < n; i++)
            {
                sumD += diff[i]; // 累加差分值
                long m = low - (power[i] + sumD);
                if (m <= 0)
                {
                    continue;
                }
                // 需要在 i+r 额外建造 m 个供电站
                built += m;
                if (built > k)
                { // 不满足要求
                    return false;
                }
                // 把区间 [i, i+2r] 加一
                sumD += m; // 由于 diff[i] 后面不会再访问，我们直接加到 sumD 中
                diff[Math.Min(i + r * 2 + 1, n)] -= m;
            }
            return true;
        }

    }
}
