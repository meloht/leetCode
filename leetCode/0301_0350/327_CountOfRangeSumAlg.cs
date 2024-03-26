using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _327_CountOfRangeSumAlg
    {
        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            var resultList = new List<int>();

            Discretization(nums);

            Init(nums.Length + 5);

            for (int i = nums.Length - 1; i >= 0; --i)
            {
                var id = GetId(nums[i]);
                resultList.Add(Query(id - 1));
                Update(id);
            }

            resultList.Reverse();

            return 0;
        }


        private int[] c;

        private int[] a;

        private void Init(int length)
        {
            c = new int[length];
            Array.Fill(c, 0);
        }

        private int LowBit(int x)
        {
            return x & (-x);
        }

        private void Update(int pos)
        {
            while (pos < c.Length)
            {
                c[pos] += 1;
                pos += LowBit(pos);
            }
        }

        private int Query(int pos)
        {
            int ret = 0;
            while (pos > 0)
            {
                ret += c[pos];
                pos -= LowBit(pos);
            }

            return ret;
        }

        private void Discretization(int[] nums)
        {
            a = (int[])nums.Clone();
            var hashSet = new HashSet<int>(a);
            a = hashSet.ToArray();
            Array.Sort(a);
        }

        private int GetId(int x)
        {
            return Array.BinarySearch(a, x) + 1;
        }
    }
}
