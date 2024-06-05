using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3072_DistributeElementsIntoTwoArraysIIAlg
    {
        public int[] ResultArray1(int[] nums)
        {
            List<int> arr1 = [nums[0]];
            List<int> arr2 = [nums[1]];

            List<int> arr11 = [nums[0]];
            List<int> arr22 = [nums[1]];

            for (int i = 2; i < nums.Length; i++)
            {
                int num1 = GreaterCountVal(arr11, nums[i]);
                int count1 = arr11.Count - num1;

                int num2 = GreaterCountVal(arr22, nums[i]);
                int count2 = arr22.Count - num2;
                if (count1 > count2)
                {
                    arr1.Add(nums[i]);
                    InsertVal(arr11, num1, nums[i]);
                }
                else if (count1 < count2)
                {
                    arr2.Add(nums[i]);
                    InsertVal(arr22, num2, nums[i]);
                }
                else
                {
                    if (arr1.Count > arr2.Count)
                    {
                        arr2.Add(nums[i]);
                        InsertVal(arr22, num2, nums[i]);
                    }
                    else
                    {
                        arr1.Add(nums[i]);
                        InsertVal(arr11, num1, nums[i]);
                    }

                }
            }
            arr1.AddRange(arr2);
            return arr1.ToArray();
        }


        public void InsertVal(List<int> ls,int index,int val)
        {
            if (index > ls.Count - 1)
            {
                ls.Add(val);
            }
            else
            {
                ls.Insert(index, val);
            }
        }

        public int GreaterCountVal(List<int> arr1, int target)
        {
            int left = 0;
            int right = arr1.Count - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (arr1[mid] <= target)
                {
                    left = mid + 1;
                    ans = left;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans;
        }

        public int[] ResultArray(int[] nums)
        {
            int n = nums.Length;
            int[] sortedNums = nums.ToArray();
            Array.Sort(sortedNums);

            IDictionary<int, int> index = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                index.TryAdd(sortedNums[i], i + 1);
            }

            IList<int> arr1 = new List<int> { nums[0] };
            IList<int> arr2 = new List<int> { nums[1] };
            BinaryIndexedTree tree1 = new BinaryIndexedTree(n);
            BinaryIndexedTree tree2 = new BinaryIndexedTree(n);
            tree1.Add(index[nums[0]]);
            tree2.Add(index[nums[1]]);

            for (int i = 2; i < n; i++)
            {
                int count1 = arr1.Count - tree1.Get(index[nums[i]]);
                int count2 = arr2.Count - tree2.Get(index[nums[i]]);
                if (count1 > count2 || (count1 == count2 && arr1.Count <= arr2.Count))
                {
                    arr1.Add(nums[i]);
                    tree1.Add(index[nums[i]]);
                }
                else
                {
                    arr2.Add(nums[i]);
                    tree2.Add(index[nums[i]]);
                }
            }

            int idx = 0;
            foreach (int a in arr1)
            {
                nums[idx++] = a;
            }
            foreach (int a in arr2)
            {
                nums[idx++] = a;
            }
            return nums;
        }


    }

    class BinaryIndexedTree
    {
        private int[] tree;

        public BinaryIndexedTree(int n)
        {
            tree = new int[n + 1];
        }

        public void Add(int i)
        {
            while (i < tree.Length)
            {
                tree[i]++;
                i += i & -i;
            }
        }

        public int Get(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += tree[i];
                i -= i & -i;
            }
            return sum;
        }
    }


}
