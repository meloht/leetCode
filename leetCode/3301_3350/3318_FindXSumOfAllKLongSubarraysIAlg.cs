using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3318_FindXSumOfAllKLongSubarraysIAlg
    {
        public long[] FindXSum(int[] nums, int k, int x)
        {
            Helper helper = new Helper(x);
            List<long> ans = new List<long>();

            for (int i = 0; i < nums.Length; i++)
            {
                helper.Insert(nums[i]);
                if (i >= k)
                {
                    helper.Remove(nums[i - k]);
                }
                if (i >= k - 1)
                {
                    ans.Add(helper.Get());
                }
            }

            return ans.ToArray();
        }

        public class Helper
        {
            private int x;
            private long result;
            private SortedSet<(int, int)> large, small;
            private Dictionary<int, int> occ;

            public Helper(int x)
            {
                this.x = x;
                this.result = 0;
                this.large = new SortedSet<(int, int)>();
                this.small = new SortedSet<(int, int)>();
                this.occ = new Dictionary<int, int>();
            }

            public void Insert(int num)
            {
                if (occ.ContainsKey(num) && occ[num] > 0)
                {
                    InternalRemove((occ[num], num));
                }
                occ[num] = occ.GetValueOrDefault(num, 0) + 1;
                InternalInsert((occ[num], num));
            }

            public void Remove(int num)
            {
                InternalRemove((occ[num], num));
                occ[num]--;
                if (occ[num] > 0)
                {
                    InternalInsert((occ[num], num));
                }
            }

            public long Get()
            {
                return result;
            }

            private void InternalInsert((int, int) p)
            {
                if (large.Count < x || Compare(p, large.Min) > 0)
                {
                    result += (long)p.Item1 * p.Item2;
                    large.Add(p);
                    if (large.Count > x)
                    {
                        var toRemove = large.Min;
                        result -= (long)toRemove.Item1 * toRemove.Item2;
                        large.Remove(toRemove);
                        small.Add(toRemove);
                    }
                }
                else
                {
                    small.Add(p);
                }
            }

            private void InternalRemove((int, int) p)
            {
                if (Compare(p, large.Min) >= 0)
                {
                    result -= (long)p.Item1 * p.Item2;
                    large.Remove(p);
                    if (small.Count > 0)
                    {
                        var toAdd = small.Max;
                        result += (long)toAdd.Item1 * toAdd.Item2;
                        small.Remove(toAdd);
                        large.Add(toAdd);
                    }
                }
                else
                {
                    small.Remove(p);
                }
            }

            private int Compare((int, int) a, (int, int) b)
            {
                if (a.Item1 != b.Item1) return a.Item1.CompareTo(b.Item1);
                return a.Item2.CompareTo(b.Item2);
            }
        }


    }
}
