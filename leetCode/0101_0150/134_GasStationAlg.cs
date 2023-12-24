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
            int t2 = 0;
            int begin = -1;
            for (int i = 0; i < gas.Length; i++)
            {
                int dec = gas[i] - cost[i];

                if (dec >= 0 && begin == -1)
                {
                    begin = i;
                }
                if (begin != -1)
                {
                    if (t2 >= 0)
                    {
                        t2 += dec;
                    }
                    else
                    {
                        t1 += t2;
                        if (dec > 0)
                        {
                            t2 = dec;
                            begin = i;
                        }
                        else
                        {
                            t2 = 0;
                            t1 += dec;
                            begin = -1;
                        }

                    }

                }
                else
                {
                    t1 += dec;
                }

            }
            int total = t1 + t2;
            if (total >= 0)
                return begin;

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
