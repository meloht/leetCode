using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _315_CountOfSmallerNumbersAfterSelfAlg
    {

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

        public IList<int> CountSmaller1(int[] nums)
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

            return resultList;
        }



        public IList<int> CountSmaller(int[] nums)
        {
            this.index = new int[nums.Length];
            this.temp = new int[nums.Length];
            this.tempIndex = new int[nums.Length];
            this.ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; ++i)
            {
                index[i] = i;
            }

            int l = 0, r = nums.Length - 1;
            MergeSort(nums, l, r);

            return new List<int>(ans);
        }


        private int[] index;

        private int[] temp;

        private int[] tempIndex;

        private int[] ans;

        public void Merge(int[] a, int l, int mid, int r)
        {
            int i = l, j = mid + 1, p = l;
            while (i <= mid && j <= r)
            {
                if (a[i] <= a[j])
                {
                    temp[p] = a[i];
                    tempIndex[p] = index[i];
                    ans[index[i]] += (j - mid - 1);
                    ++i;
                    ++p;
                }
                else
                {
                    temp[p] = a[j];
                    tempIndex[p] = index[j];
                    ++j;
                    ++p;
                }
            }

            while (i <= mid)
            {
                temp[p] = a[i];
                tempIndex[p] = index[i];
                ans[index[i]] += (j - mid - 1);
                ++i;
                ++p;
            }

            while (j <= r)
            {
                temp[p] = a[j];
                tempIndex[p] = index[j];
                ++j;
                ++p;
            }

            for (int k = l; k <= r; ++k)
            {
                index[k] = tempIndex[k];
                a[k] = temp[k];
            }
        }

        public void MergeSort(int[] a, int l, int r)
        {
            if (l >= r)
            {
                return;
            }

            int mid = (l + r) >> 1;
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, r);
            Merge(a, l, mid, r);
        }
    }
}
