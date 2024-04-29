using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.数组
{
    public class ArrayUtilsTemplate
    {
        /// <summary>
        /// 添加数组中缺失的数字，使得数组可以表示【1-n】任何数
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MinPatches(int[] nums, int n)
        {
            Array.Sort(nums);
            long total = 1;
            long i = 0;
            int count = 0;
            while (total <= n)
            {
                if (i < nums.Length && nums[i] <= total)
                {
                    total += nums[i];
                    i++;
                }
                else
                {
                    total = total * 2;
                    count++;
                }
            }

            return count;
        }
    }
}
