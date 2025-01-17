using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _898_BitwiseOrsOfSubarraysAlg
    {
        public int SubarrayBitwiseORs(int[] arr)
        {
            int n = arr.Length;
            List<int[]> ors = new List<int[]>(); // 按位或的值 + 对应子数组的右端点的最小值
            HashSet<int> set = new HashSet<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                ors.Add([0, i]);
                int k = 0;
                for (int j = 0; j < ors.Count; j++)
                {
                    var item = ors[j];
                    item[0] |= arr[i];// 更新按位或的值
                    if (ors[k][0] == item[0])
                    {
                        ors[k][1] = item[1];// 合并相同值，下标取最小的
                    }
                    else
                    {
                        k++;
                        ors[k] = item;// 更新列表
                    }
                    set.Add(item[0]);
                }
               
                ors.RemoveRange(k + 1, ors.Count - k - 1); // 删除多余的子数组
                
            }
            return set.Count;
        }

        public int SubarrayBitwiseORs1(int[] arr)
        {
            int n = arr.Length;
           
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
                for (int j = i - 1; j >= 0 && (arr[j] | arr[i]) != arr[j]; j--)
                {
                    arr[j] |= arr[i];
                    set.Add(arr[j]);
                }
            }

            return set.Count;
        }

    }
}
