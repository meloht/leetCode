using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3159_FindOccurrencesOfAnElementInAnArrayAlg
    {
        public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
        {
            int[] result = new int[queries.Length];
            List<int> dict = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == x)
                {
                    dict.Add(i);
                }
            }
            for (int i = 0; i < queries.Length; i++)
            {
                if (dict.Count >= queries[i])
                {
                    result[i] = dict[queries[i] - 1];
                }
                else
                {
                    result[i] = -1;
                }
            }


            return result;
        }
    }
}
