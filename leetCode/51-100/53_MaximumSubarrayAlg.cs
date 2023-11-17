using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _53_MaximumSubarrayAlg
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int max = GetMaxForList(nums);

            List<int> list = GetMergePlusMinus(nums);
            int len = list.Count;
            if (len == 1)
            {
                max = Math.Max(list[0], max);
                return max;
            }
            if (len == 2)
            {
                max = Math.Max(list[0], list.Max());
                return max;
            }

            while (list.Count > 1 && list[0] <= 0)
            {
                list.RemoveAt(0);
            }
            while (list.Count > 1 && list[list.Count - 1] <= 0)
            {
                list.RemoveAt(list.Count - 1);
            }

            List<int> listNext = list;
            if (len > 2)
            {
                listNext = GetMergeList(list);
                int lenNext = listNext.Count;
                while (lenNext < len)
                {
                    len = lenNext;
                    listNext = GetMergeList(listNext);
                    lenNext = listNext.Count;
                }

            }
            if (listNext.Count == 1)
            {
                int maxNum = listNext.Max();
                return Math.Max(max, maxNum);
            }

            if (listNext.Count > 0)
            {
                len = listNext.Count;
                int maxNum = listNext.Max();

                List<int> plusList = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    if (listNext[i] > 0)
                    {
                        plusList.Add(i);
                    }
                }

                foreach (int i in plusList)
                {
                    int num = GetMergeListMax(listNext, i);
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                }
                if (maxNum > max)
                {
                    max = maxNum;
                }
            }
            return max;
        }
        private int GetMaxForList(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            foreach (int num in nums)
            {
                max = Math.Max(max, num);
                sum += num;
            }
            max = Math.Max(max, sum);
            return max;
        }
        private int GetMergeListMax(List<int> res, int index)
        {
            int num = 0;
            int left = index - 1;
            int leftMax = int.MinValue;
            for (int i = left; i >= 0; i--)
            {
                num += res[i];
                if (num > leftMax)
                {
                    leftMax = num;
                }
            }
            num = 0;
            int right = index + 1;
            int rightMax = int.MinValue;
            for (int i = right; i < res.Count; i++)
            {
                num += res[i];
                if (num > rightMax)
                {
                    rightMax = num;
                }
            }

            int max = res[index];
            if (leftMax > 0)
            {
                max += leftMax;
            }
            if (rightMax > 0)
            {
                max += rightMax;
            }
            return max;
        }

        private List<int> GetMergeList2(List<int> res)
        {
            List<int> list = new List<int>();
            int len = res.Count;
            int i = 0;
            while (i < len)
            {

            }
            return list;
        }
        private List<int> GetMergeList(List<int> res)
        {
            List<int> list = new List<int>();
            int len = res.Count;
            int indexPlus2 = 0;
            int indexMinus = 0;
            int plusNum2 = 0;
            int minusNum = 0;
            int plusNum1 = 0;
            int i = 0;
            while (i < len)
            {
                minusNum = 0;
                plusNum2 = 0;

                plusNum1 = res[i];
                indexMinus = i + 1;
                indexPlus2 = i + 2;
                if (indexMinus < len)
                {
                    minusNum = res[indexMinus];
                }
                else
                {
                    list.Add(plusNum1);
                    break;
                }
                if (indexPlus2 < len)
                {
                    plusNum2 = res[indexPlus2];
                }
                else
                {
                    list.Add(plusNum1);
                    break;
                }

                int maxPlus = Math.Max(plusNum1, plusNum2);

                int newNum = Math.Min(plusNum1, plusNum2) + minusNum;
                if (newNum > 0)
                {
                    list.Add(newNum + maxPlus);
                    int index = i + 3;
                    if (index < len)
                    {
                        list.Add(res[index]);
                    }
                    i += 4;
                }
                else
                {

                    list.Add(plusNum1);
                    if (minusNum < 0)
                    {
                        list.Add(minusNum);
                    }
                    i += 2;
                }

            }
            return list;
        }
        private List<int> GetMergePlusMinus(int[] nums)
        {
            int len = nums.Length;
            int num = 0;
            List<int> list = new List<int>();

            int index = 0;
            int nextIndex = 0;
            int nextNum = 0;
            int sum = 0;

            while (index < len)
            {
                num = nums[index];
                sum += num;
                nextIndex = index + 1;
                if (nextIndex < len)
                {
                    nextNum = nums[nextIndex];
                    if (nextNum >= 0)
                    {
                        if (num < 0)
                        {
                            list.Add(sum);
                            sum = 0;
                        }

                    }
                    else if (nextNum < 0)
                    {
                        if (num >= 0)
                        {
                            list.Add(sum);
                            sum = 0;
                        }
                    }
                }
                else
                {
                    list.Add(sum);
                }
                index++;
            }
            return list;
        }

    }
}
