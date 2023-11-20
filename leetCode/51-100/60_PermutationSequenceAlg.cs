using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _60_PermutationSequenceAlg
    {


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

            int num = k;

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                if (n == i)
                {
                    int mm = list[0];
                    sb.Append(mm);
                }
                else
                {
                    int dec = num / dict[n - i];
                    int rem = num % dict[n - i];
                    num = rem;
                    if (dec == 1 && rem == 0 && dict[n - i] == 1)
                    {
                        int t = list[dec - 1];
                        sb.Append(t);
                        list.RemoveAt(dec - 1);
                    }
                    else
                    {
                        int t = list[dec];
                        sb.Append(t);
                        list.RemoveAt(dec);
                    }

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
