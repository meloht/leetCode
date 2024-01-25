using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _560_SubarraySumEqualsKAlg
    {
        public int SubarraySum1(int[] nums, int k)
        {
            int n = nums.Length;
            int[] arr = new int[n];
            arr[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + nums[i];
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (j == i)
                    {
                        if (nums[i] == k)
                        {
                            ans++;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (arr[j] == k)
                            {
                                ans++;
                            }
                        }
                        else
                        {
                            int num = arr[j] - arr[i - 1];
                            if (num == k)
                            {
                                ans++;
                            }
                        }

                    }

                }
            }


            return ans;
        }

        public int SubarraySum(int[] nums, int k)
        {
            int count = 0, pre = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                pre += nums[i];
                if (dict.ContainsKey(pre - k))
                {
                    count += dict[pre - k];
                }
    
                if (dict.ContainsKey(pre))
                {
                    dict[pre]++;
                }
                else
                {
                    dict.Add(pre, 1);
                }
            }
            return count;


        }
        public int SubarraySum3(int[] nums, int k)
        {
            int res = 0, pre = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                pre += nums[i];
                if (dic.ContainsKey(pre - k))
                {
                    res += dic[pre - k];
                }
                if (!dic.ContainsKey(pre))
                {
                    dic.Add(pre, 1);
                }
                else
                {
                    dic[pre]++;
                }
            }

            return res;
        }

    }
}
