using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{

    public class _830_PositionsOfLargeGroupsAlg
    {
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            List<IList<int>> res = new List<IList<int>>();
            int count = 1;
            char prev = s[0];
            int begin = 0;
            int end = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == prev)
                {
                    count++;
                    end = i;
                }
                else
                {
                    prev= s[i];
                    if (count >= 3)
                    {
                        res.Add([begin, end]);
                    }
                    count = 1;
                    begin = i;
                    end = i;
                }
            }
            if (count >= 3)
            {
                res.Add([begin, end]);
            }
            res.Sort((x, y) => x[0].CompareTo(y[0]));
            return res;
        }
    }
}
