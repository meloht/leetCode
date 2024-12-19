using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3285_FindIndicesOfStableMountainsAlg
    {
        public IList<int> StableMountains(int[] height, int threshold)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < height.Length; i++)
            {
                if (threshold < height[i - 1])
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
