using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2960_CountTestedDevicesAfterTestOperationsAlg
    {
        public int CountTestedDevices(int[] batteryPercentages)
        {
            int count = 0;
            for (int i = 0; i < batteryPercentages.Length; i++)
            {
                if (batteryPercentages[i] > 0)
                {
                    count++;
                    for (int j = i + 1; j < batteryPercentages.Length; j++)
                    {
                        batteryPercentages[j] = Math.Max(0, batteryPercentages[j] - 1);
                    }
                }
            }
            return count;
        }

        public int CountTestedDevices1(int[] batteryPercentages)
        {
            int need = 0;
            foreach (int battery in batteryPercentages)
            {
                if (battery > need)
                {
                    need++;
                }
            }
            return need;
        }


    }
}
