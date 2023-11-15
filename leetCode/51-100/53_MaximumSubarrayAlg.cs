using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
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

            int max = nums.Max();
            int sum = nums.Sum();
            if (sum > max)
            {
                max = sum;
            }
            if (nums.Length <= 2)
            {
                return max;
            }

            List<int> list = GetMergePlusAndMinus(nums);
            int len = list.Count;
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
            int maxt = listNext.Max();
            if (maxt > max)
            {
                max = maxt;
            }

            return max;
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
                if (indexPlus2 < len)
                {
                    plusNum2 = res[indexPlus2];
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
        private List<int> GetMergePlusAndMinus(int[] nums)
        {
            int len = nums.Length;
            int num = 0;
            List<int> list = new List<int>();

            int index = 1;
          
            bool flagPlus = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    flagPlus = nums[i] > 0;
                    num = nums[i];
                    break;
                }
            }

            while (index < len)
            {
                int temp = nums[index];
                if (temp == 0)
                {
                    index++;
                    continue;
                }
                if (temp >= 0 && flagPlus == false)
                {
                    flagPlus = true;
                    list.Add(num);
                    num = 0;
                    num += temp;
                }
                else if (temp >= 0 && flagPlus)
                {
                    num += temp;
                }
                else if (temp < 0 && flagPlus)
                {
                    flagPlus = false;
                    list.Add(num);
                    num = 0;
                    num += temp;
                }
                else if (temp < 0 && flagPlus == false)
                {
                    num += temp;
                }
                if (index == len - 1)
                {
                    list.Add(num);
                }
                index++;
            }

            if (list.Count > 1 && list[0] <= 0)
            {
                list.RemoveAt(0);
            }
            if (list.Count > 1 && list[list.Count - 1] <= 0)
            {
                list.RemoveAt(list.Count - 1);
            }
            return list;
        }
        public int MaxSubArray1(int[] nums)
        {
            int max = nums.Max();
            int sum = nums.Sum();
            if (sum > max)
            {
                max = sum;
            }
            int len = nums.Length;
            int index = 0;
            for (int i = 2; i <= len - 1; i++)
            {
                index = 0;
                while (index < len)
                {
                    int count = index + i;
                    sum = 0;
                    for (int j = index; j < count && j < len; j++)
                    {
                        sum += nums[j];
                    }
                    if (sum > max)
                    {
                        max = sum;
                    }
                    index++;
                }
            }

            return max;
        }
    }
}
