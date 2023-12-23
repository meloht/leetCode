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
            for (int i = 0; i < gas.Length; i++)
            {
                if (gas[i] >= cost[i] && gas[i] > 0)
                {
                    bool bl = IsPass(i, gas, cost);
                    if (bl)
                        return i;
                }
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
