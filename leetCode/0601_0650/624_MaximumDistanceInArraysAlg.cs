using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _624_MaximumDistanceInArraysAlg
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxIdx = 0;
            int minIdx = 0;

            for (int i = 0; i < arrays.Count; i++)
            {
                if (max < arrays[i][arrays[i].Count - 1])
                {
                    maxIdx = i;
                    max = arrays[i][arrays[i].Count - 1];
                }

                if (min > arrays[i][0])
                {
                    minIdx = i;
                    min = arrays[i][0];
                }
            }

            if (maxIdx != minIdx)
            {
                return Math.Abs(max - min);
            }
            int min1 = GetMin(arrays, maxIdx);
            int nn1 = Math.Abs(max - min1);

            int max1 = GetMax(arrays, maxIdx);
            int nn2 = Math.Abs(max1 - min);
            return Math.Max(nn1, nn2);
        }
        private int GetMax(IList<IList<int>> arrays, int idx)
        {
            int max = int.MinValue;
            for (int i = 0; i < arrays.Count; i++)
            {
                if (i == idx)
                    continue;

                if (max < arrays[i][arrays[i].Count - 1])
                {

                    max = arrays[i][arrays[i].Count - 1];
                }


            }
            return max;
        }

        private int GetMin(IList<IList<int>> arrays, int idx)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arrays.Count; i++)
            {
                if (i == idx)
                    continue;

                if (min > arrays[i][0])
                {
                    min = arrays[i][0];
                }


            }
            return min;
        }

        public int MaxDistance1(IList<IList<int>> arrays)
        {
            int res = 0;
            int n = arrays.Count;
            int min_val = arrays[0][0];
            int max_val = arrays[0][arrays[0].Count-1];
            for (int i = 1; i < arrays.Count; i++)
            {
                n = arrays[i].Count;
                res = Math.Max(res, Math.Max(Math.Abs(arrays[i][n-1] - min_val),
                                             Math.Abs(max_val - arrays[i][0])));
                min_val = Math.Min(min_val, arrays[i][0]);
                max_val = Math.Max(max_val, arrays[i][n - 1]);
            }
            return res;
        }


    }
}
