using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._0201_0250
{
    public class _218_TheSkylineProblemAlg
    {
       

        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            List<IList<int>> res = new List<IList<int>>();
            HashSet<int> set = new HashSet<int>();

            Dictionary<int, List<int[]>> dictLeft = new Dictionary<int, List<int[]>>();
            foreach (int[] item in buildings)
            {
                if (dictLeft.ContainsKey(item[0]))
                {
                    dictLeft[item[0]].Add(item);
                }
                else
                {
                    var ls = new List<int[]>();
                    ls.Add(item);
                    dictLeft.Add(item[0], ls);
                }
                set.Add(item[0]);
                set.Add(item[1]);
            }

            List<int> listSet = set.ToList();
            listSet.Sort();
            List<int[]> list = new List<int[]>();
            Dictionary<int, int> dictMax = new Dictionary<int, int>();
            for (int i = 0; i < listSet.Count; i++)
            {
                int num = listSet[i];
                list = list.Where(p => p[0] <= num && p[1] > num).ToList();
                if (dictLeft.ContainsKey(num))
                {
                    var ls = dictLeft[num];
                    list.AddRange(ls);
                }
                int max = 0;
                if (list.Count > 0)
                {
                    max = list.Max(p => p[2]);
                }

                dictMax.Add(num, max);
            }
  
            res.Add(new int[] { listSet[0], dictMax[listSet[0]] });
            for (int i = 1; i < listSet.Count; i++)
            {
                int prev = listSet[i-1];
                int prevH = dictMax[prev];

                int curr = listSet[i];
                int currH = dictMax[curr];
                if (currH != prevH)
                {
                    res.Add(new int[] { curr, currH });
                }
            }

            return res;
        }


    }
}
