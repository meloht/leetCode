using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2610_ConvertAnArrayIntoA2dArrayWithConditionsAlg
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();

            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>(nums);
            while (list.Count > 0)
            {
                set.Clear();
                List<int> rows = new List<int>();
                List<int> list2 = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (set.Add(list[i]))
                    {
                        rows.Add(list[i]);
                    }
                    else
                    {
                        list2.Add(list[i]);
                    }
                }
                res.Add(rows);
                list = list2;
            }
            return res;
        }
    }
}
