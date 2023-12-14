using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._1_50
{
    public class _39_CombinationSumAlg
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<int> listMin = new List<int>();

            foreach (var item in candidates)
            {
                if (item <= target)
                {
                    listMin.Add(item);
                }
            }
            listMin.Sort();
            IList<IList<int>> res = new List<IList<int>>();
            if (listMin.Count == 0)
            {
                return res;
            }

            int index = 0;
            foreach (var item in listMin)
            {
                GetNodeCount(item, index, listMin, target, res);
                index++;
            }

            return res;
        }
        private void GetNodeCount(int currentNum, int index, List<int> listMin, int target, IList<IList<int>> res)
        {
            int remainder = target % currentNum;
            int numCount = target / currentNum;
            int diff = remainder;
            if (remainder == 0 && numCount > 0)
            {
                res.Add(AddNum(currentNum, numCount));
                if (numCount > 2)
                {
                    numCount -= 2;
                }
                else
                {
                    return;
                }
            }
            else
            {
                numCount--;
            }

            int sum = 0;
            for (int i = 1; i <= numCount; i++)
            {
                List<int> arr = AddNum(currentNum, i);
                sum = currentNum * i;
                diff = target - sum;

                AddNextNum(arr, res, diff, index + 1, listMin);

            }

        }
        private void AddNextNum(List<int> preList, IList<IList<int>> res, int diff, int nextIndex, List<int> listMin)
        {
            List<int> list = new List<int>(preList);

            for (int i = nextIndex; i < listMin.Count; i++)
            {
                int nextNum = listMin[i];

                if (nextNum > diff)
                {
                    break;
                }
                else if (diff == nextNum)
                {

                    list.Add(nextNum);
                    res.Add(list);
                    list = new List<int>(preList);
                    break;

                }
                else
                {
                    int ress = diff % nextNum;
                    int nextCount = diff / nextNum;
                    if (ress == 0)
                    {
                        AddNumList(nextNum, nextCount, list);
                        res.Add(list);
                        list = new List<int>(preList);
                        nextCount--;
                    }
                    while (nextCount > 0)
                    {
                        int diffff = diff - nextNum * nextCount;

                        if (diffff > nextNum)
                        {
                            AddNumList(nextNum, nextCount, list);
                            AddNextNum(list, res, diffff, i + 1, listMin);
                            list = new List<int>(preList);
                        }

                        nextCount--;
                    }
                }
            }
        }

        private List<int> AddNum(int num, int count)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < count; i++)
            {
                arr.Add(num);
            }
            return arr;
        }

        private void AddNumList(int num, int count, List<int> arr)
        {
            for (int i = 0; i < count; i++)
            {
                arr.Add(num);
            }
        }

    }
}
