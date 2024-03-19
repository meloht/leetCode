using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _260_SingleNumberIIIAlg
    {
        public int[] SingleNumber(int[] nums)
        {
            var res = nums.GroupBy(x => x).Where(p => p.Count() == 1).Select(x => x.Key).ToArray();
            return res;
        }
    }
}
