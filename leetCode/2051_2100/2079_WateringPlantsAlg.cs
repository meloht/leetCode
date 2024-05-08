using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2079_WateringPlantsAlg
    {
        public int WateringPlants(int[] plants, int capacity)
        {
            int num = capacity;
            int count = 0;
            for (int i = 0; i < plants.Length; i++)
            {
                if (num >= plants[i])
                {
                    num -= plants[i];
                    count++;
                }
                else
                {
                    count += i  * 2;
                    num = capacity;
                    num -= plants[i];
                    count++;
                }
            }
            return count;
        }
    }
}
