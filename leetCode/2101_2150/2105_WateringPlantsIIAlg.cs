using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2105_WateringPlantsIIAlg
    {
        public int MinimumRefill(int[] plants, int capacityA, int capacityB)
        {
            int num1 = capacityA;
            int num2 = capacityB;
            int count = 0;

            for (int i = 0, j = plants.Length - 1; i <= j; i++, j--)
            {
                if (i == j)
                {
                    if (num1 >= num2)
                    {
                        if (plants[i] > num1)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        if (plants[j] >num2)
                        {
                            count++;
                        }
                    }
                    break;
                }
                if (plants[i] <= num1)
                {
                    num1 -= plants[i];
                }
                else
                {
                    num1 = capacityA;
                    num1 -= plants[i];
                    count++;
                }

                if (plants[j] <= num2)
                {
                    num2 -= plants[j];
                }
                else
                {
                    num2 = capacityB;
                    num2 -= plants[j];
                    count++;
                }
            }

            return count;
        }
    }
}
