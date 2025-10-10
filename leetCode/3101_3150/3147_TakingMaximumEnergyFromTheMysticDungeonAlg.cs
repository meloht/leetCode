using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3147_TakingMaximumEnergyFromTheMysticDungeonAlg
    {
        public int MaximumEnergy(int[] energy, int k)
        {
            int n = energy.Length;
            int ans = int.MinValue;
            for (int i = n - k; i < n; i++)
            { // 枚举终点 i
                int sufSum = 0;
                for (int j = i; j >= 0; j -= k)
                {
                    sufSum += energy[j]; // 计算后缀和
                    ans = Math.Max(ans, sufSum);
                }
            }
            return ans;


        }
    }
}
