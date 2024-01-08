using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _218_TheSkylineProblemAlg
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            long begin = long.MaxValue;
            long end = long.MinValue;
            foreach (int[] item in buildings)
            {
                begin = Math.Min(begin, item[0]);
                end = Math.Max(end, item[1]);
            }
            long[] res = new long[end + 1];

            foreach (int[] item in buildings)
            {
                for (long i = item[0]; i <= item[1]; i++)
                {
                    res[i] = Math.Max(item[2], res[i]);
                }
            }

            List<IList<int>> list = new List<IList<int>>();
            list.Add(new int[] { (int)begin, (int)res[begin] });
            for (long i = begin + 1; i <= end; i++)
            {
                long prev = res[i - 1];
                long curr = res[i];
                if (prev != curr)
                {
                    if (prev > curr)
                    {
                        list.Add(new int[] { (int)i - 1, (int)res[i] });
                    }
                    else
                    {
                        list.Add(new int[] { (int)i, (int)res[i] });
                    }
                }
            }

            list.Add(new int[] { (int)end, 0 });
            return list;
        }
    }
}
