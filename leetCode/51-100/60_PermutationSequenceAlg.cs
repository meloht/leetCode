using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._51_100
{
    public class _60_PermutationSequenceAlg
    {

        public string GetPermutation3(int n, int k)
        {
            int[] factorial = new int[n];
            factorial[0] = 1;
            for (int i = 1; i < n; ++i)
            {
                factorial[i] = factorial[i - 1] * i;
            }

            --k;
            StringBuilder ans = new StringBuilder();
            int[] valid = new int[n + 1];
            for (int i = 0; i < valid.Length; i++)
            {
                valid[i] = 1;
            }
            for (int i = 1; i <= n; ++i)
            {
                int order = k / factorial[n - i] + 1;
                for (int j = 1; j <= n; ++j)
                {
                    order -= valid[j];
                    if (order == 0)
                    {
                        ans.Append(j);
                        valid[j] = 0;
                        break;
                    }
                }
                k %= factorial[n - i];
            }
            return ans.ToString();
        }


        public string GetPermutation(int n, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
                if (i == 1)
                {
                    dict[i] = i;
                }
                else
                {
                    dict[i] = dict[i - 1] * i;
                }
            }

            int num = k - 1;
            int last = n - 1;

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (n == i)
                {
                    int mm = list[0];
                    sb.Append(mm);
                }
                else if (i == last)
                {
                    int t = list[num];
                    sb.Append(t);
                    list.RemoveAt(num);

                }
                else
                {
                    int dec = num / dict[n - i];
                    int rem = num % dict[n - i];
                    num = rem;
                    
                    int t = list[dec];
                    sb.Append(t);
                    list.RemoveAt(dec);

                }
            }
            return sb.ToString();
        }

        int count = 0;
        string res = "";
        public string GetPermutation1(int n, int k)
        {
            List<int> ints = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                ints.Add(i);
            }
            var nums = ints.ToArray();

            if (nums.Length == 1)
            {
                return "1";
            }
            List<int> current = new List<int>();
            bool[] used = new bool[nums.Length];
            Permute(nums, current, used, k);
            return res;
        }


        private void Permute(int[] candidates, List<int> current, bool[] used, int k)
        {
            if (current.Count == candidates.Length)
            {
                count++;
                if (count == k)
                {
                    res = string.Join("", current);
                }

                return;
            }

            for (int i = 0; i < candidates.Length; i++)
            {
                if (count == k)
                    return;

                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                current.Add(candidates[i]);
                Permute(candidates, current, used, k);
                used[i] = false;
                current.RemoveAt(current.Count - 1);

            }
        }
    }
}
