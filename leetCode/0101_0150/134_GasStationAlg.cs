using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _134_GasStationAlg
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int t1 = 0;

            int begin = -1;
            for (int i = 0; i < gas.Length; i++)
            {
                t1 += gas[i];
                t1 -= cost[i];
                if (t1 >= 0)
                {
                    begin = i;
                    break;
                }
            }
            if (begin > -1 && gas[begin] >= cost[begin] && gas[begin] > 0)
            {
                bool bl = IsPass(begin, gas, cost);
                if (bl)
                    return begin;
            }
            return -1;
        }
        private bool IsPass(int begin, int[] gas, int[] cost)
        {
            int index = begin;
            int total = 0;
            while (true)
            {
                total += gas[index];
                total = total - cost[index];
                if (total >= 0)
                {
                    index++;
                    index = index % gas.Length;
                    if (index == begin)
                        return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
