using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _384_ShuffleAnArrayAlg
    {
        Random random = new Random();
        int[] orginal = null;
        public _384_ShuffleAnArrayAlg(int[] nums)
        {
            orginal = nums;
        }

        public int[] Reset()
        {
            return orginal;
        }

        public int[] Shuffle()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < orginal.Length; i++)
            {
                list.Add(i);
            }
            int[] res = new int[list.Count];
            int j = 0;
            while (list.Count > 0)
            {
                int index = random.Next(list.Count);
                int indexOriginal = list[index];
                res[j] = orginal[indexOriginal];
                list.RemoveAt(index);
                j++;
            }
            return res;
        }
    }
}
